using System;
using System.Windows.Forms;
using System.Linq;
using MavLink;
using System.ComponentModel;

namespace Avionics
{
    public partial class AvionicsDisplay : Form
    {

        LogAttributesContainer attributesContainer;
        int totalMillisecondsDifference;
        Timer dispatcherTimer = new Timer();
        private DateTime endTime;
        private DateTime startTime;
        int maxTimeMs;
        int minTimeMs;
        GoogleMap googleMap;
        string fileName;
        Mavlink Mv = new Mavlink();
        Msg_heartbeat Hb = new Msg_heartbeat();
        Msg_sys_status Ss = new Msg_sys_status();
        Msg_power_status Ps = new Msg_power_status();
        Msg_attitude At = new Msg_attitude();
        Msg_gps_raw_int Gps = new Msg_gps_raw_int();
        Msg_vfr_hud Vfr = new Msg_vfr_hud();
        Msg_data_stream Ds = new Msg_data_stream();
        Msg_raw_pressure Rp = new Msg_raw_pressure();
        Msg_statustext St = new Msg_statustext();
        Msg_mission_count Mc = new Msg_mission_count();
        Msg_mission_item[] Mi = new Msg_mission_item[32];
        Msg_system_time Ti = new Msg_system_time();
        int Systemid;
        int Componentid;
        int Sequence;
        Boolean HB = true;
        volatile int MI = -1;
        public static string FrameworkDescription { get; }
        public AvionicsDisplay()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            dispatcherTimer = new Timer();
            googleMap = new GoogleMap(map);
            googleMap.Initialize();

            //MavLink
            Baud.SelectedIndex = 3;
            Mv.PacketReceived += Mv_PacketReceived;
            String[] P = System.IO.Ports.SerialPort.GetPortNames();
            if (P.Length > 0)
                Comm.Text = P[0];
            Mi[0] = new Msg_mission_item();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        void timer_Tick(Object myObject, EventArgs myEventArgs)
        {
            UpdateTime();
        }

        private void StartTimer()
        {
            startTime = DateTime.Now;
            endTime = DateTime.Now.AddMinutes(2);
            dispatcherTimer.Tick -= new EventHandler(timer_Tick);
            dispatcherTimer.Tick += new EventHandler(timer_Tick);
            dispatcherTimer.Interval = 1;
            dispatcherTimer.Start();
            UpdateTime();  
        }

        void UpdateTime()
        {
            var diff = DateTime.Now.Subtract(startTime);
            var adjustedMaxTime = maxTimeMs - minTimeMs;
            if (diff.TotalMilliseconds < adjustedMaxTime)
            {
                txtTime.Text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3}", diff.Hours, diff.Minutes, diff.Seconds, diff.Milliseconds);
                totalMillisecondsDifference = (int)diff.TotalMilliseconds;
                var latestData = attributesContainer.GenerateClosestData(totalMillisecondsDifference + minTimeMs);
                progressBar.Value = totalMillisecondsDifference;

                var lat = latestData?.GPSDataModel?.Latitude;
                var lon = latestData?.GPSDataModel?.Longitude;
                var alt = latestData?.GPSDataModel?.Altitude;
                var spd = latestData?.GPSDataModel?.GroundSpeed;
                var crs = latestData?.GPSDataModel?.Course;
                var vs = latestData?.GPSDataModel?.VerticalSpeed;
                var roll = latestData?.ATTDataModel?.Roll;
                var pitch = latestData?.ATTDataModel?.Pitch;

                if (lat.HasValue && lon.HasValue)
                {
                    lbl_Latitude.Text = String.Format("{0:0.0000000}", lat.Value);
                    lbl_Longitude.Text = String.Format("{0:0.0000000}", lon.Value);
                    googleMap.AddPoint(lat.Value, lon.Value);
                    double routeDis = googleMap.GetDistance();
                    lbl_Distance.Text = String.Format("{0:0.000}", routeDis);
                }
                if (alt.HasValue)
                {
                    var firstItem = attributesContainer.GpsDataDictionary.First().Value;
                    var altitud = firstItem.Altitude;
                    lbl_Altitude.Text = String.Format("{0:0.000}", alt.Value-altitud);
                }
                if (spd.HasValue)
                {
                    lbl_GroundSpeed.Text = String.Format("{0:0.000}", spd.Value);
                }
                if (vs.HasValue)
                {
                    lbl_VerticalSpeed.Text = String.Format("{0:0.000}", vs.Value);
                }
                if (crs.HasValue)
                {
                    headingIndicator.SetHeadingIndicatorParameters((int)crs.Value);
                    lbl_Heading.Text= String.Format("{0:0}", crs.Value);
                }
                if (roll.HasValue && pitch.HasValue)
                {
                    attitudeIndicator.SetAttitudeIndicatorParameters(pitch.Value, roll.Value);
                }
            }
            else
            {
                dispatcherTimer.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            dispatcherTimer.Stop();
            HB = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "log files (*.log)|*.log|All files (*.*)|*.*";
                openFileDialog.ShowDialog();
                txtLoad.Text = openFileDialog.FileName;
                fileName = txtLoad.Text;
                if(cmB_UAV.SelectedItem.Equals("3DR IRIS (mRo Pixhawk)"))
                {
                    InitializeFileData();
                }
                else
                {
                    InitializeFileDataSolo();
                }
            }
            btnStart.Enabled = true;
            btnStop.Enabled = true;
        }

        private void InitializeFileData()
        {
            attributesContainer = new LocationDataReader().ReadData(fileName);
            var firstItem = attributesContainer.GpsDataDictionary.First().Value;
            maxTimeMs = (int)attributesContainer.GetMaxTime();
            minTimeMs = (int)attributesContainer.GetMinTime();
            progressBar.Maximum = maxTimeMs - minTimeMs;
            var lat = firstItem.Latitude;
            var lon = firstItem.Longitude;
            googleMap.AddPoint(lat, lon);
            DrawChart();
        }

        private void InitializeFileDataSolo()
        {
            attributesContainer = new LocationDataReader().ReadDataSolo(fileName);
            var firstItem = attributesContainer.GpsDataDictionary.First().Value;
            maxTimeMs = (int)attributesContainer.GetMaxTime();
            minTimeMs = (int)attributesContainer.GetMinTime();
            progressBar.Maximum = maxTimeMs - minTimeMs;
            var lat = firstItem.Latitude;
            var lon = firstItem.Longitude;
            googleMap.AddPoint(lat,lon);
            DrawChart();
        }

        void DrawChart()
        {
            chart.Series.Add("Altitude");
            chart.Series.Add("Pitch");
            chart.Series.Add("Roll");
            chart.Series.Add("Ground Speed");
            chart.Series.Add("Vertical Speed");

            chart.Series["Altitude"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series["Pitch"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series["Roll"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series["Ground Speed"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series["Vertical Speed"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart.Series["Altitude"].Color = System.Drawing.Color.DarkRed;
            chart.Series["Pitch"].Color = System.Drawing.Color.Gold;
            chart.Series["Roll"].Color = System.Drawing.Color.DarkOrange;
            chart.Series["Ground Speed"].Color = System.Drawing.Color.YellowGreen;
            chart.Series["Vertical Speed"].Color = System.Drawing.Color.RoyalBlue;

            chart.Series["Altitude"].BorderWidth = 3;
            chart.Series["Pitch"].BorderWidth = 3;
            chart.Series["Roll"].BorderWidth = 3;
            chart.Series["Ground Speed"].BorderWidth = 3;
            chart.Series["Vertical Speed"].BorderWidth = 3;

            foreach (var gpsData in attributesContainer.GpsDataDictionary)
            {
                var firstItem = attributesContainer.GpsDataDictionary.First().Value;
                var altitud = firstItem.Altitude;
                chart.Series["Altitude"].Points.AddXY((gpsData.Key - minTimeMs) / 1000, gpsData.Value.Altitude-altitud);
            }
            foreach (var attData in attributesContainer.AttDataDictionary)
            {
                chart.Series["Pitch"].Points.AddXY((attData.Key - minTimeMs) / 1000, attData.Value.Pitch);
            }
            foreach (var attData in attributesContainer.AttDataDictionary)
            {
                chart.Series["Roll"].Points.AddXY((attData.Key - minTimeMs) / 1000, attData.Value.Roll);
            }
            foreach (var gpsData in attributesContainer.GpsDataDictionary)
            {
                chart.Series["Ground Speed"].Points.AddXY((gpsData.Key - minTimeMs) / 1000, gpsData.Value.GroundSpeed);
            }
            foreach (var gpsData in attributesContainer.GpsDataDictionary)
            {
                chart.Series["Vertical Speed"].Points.AddXY((gpsData.Key - minTimeMs) / 1000, gpsData.Value.VerticalSpeed);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chckAltitude_CheckedChanged(object sender, EventArgs e)
        {
            chart.Series["Altitude"].Enabled = chckAltitude.Checked;
        }

        private void chckPitch_CheckedChanged(object sender, EventArgs e)
        {
            chart.Series["Pitch"].Enabled = chckPitch.Checked;
        }

        private void chckRoll_CheckedChanged(object sender, EventArgs e)
        {
            chart.Series["Roll"].Enabled = chckRoll.Checked;
        }

        private void chckGrSpeed_CheckedChanged(object sender, EventArgs e)
        {
            chart.Series["Ground Speed"].Enabled = chckGrSpeed.Checked;
        }

        private void chckVertSpeed_CheckedChanged(object sender, EventArgs e)
        {
            chart.Series["Vertical Speed"].Enabled = chckVertSpeed.Checked;
        }


        //MAVLink
       
        void Mv_PacketReceived(object sender, MavLink.MavlinkPacket e)
        {
            uint x = Mv.PacketsReceived;
            Systemid = e.SystemId;
            Componentid = e.ComponentId;
            Sequence = e.SequenceNumber;
            MavlinkMessage m = e.Message;
            if (m.GetType() == Hb.GetType())
                Hb = (Msg_heartbeat)e.Message;
            if (m.GetType() == At.GetType())
                At = (Msg_attitude)e.Message;
            if (m.GetType() == Gps.GetType())
                Gps = (Msg_gps_raw_int)e.Message;
            if (m.GetType() == Vfr.GetType())
                Vfr = (Msg_vfr_hud)e.Message;
            if (m.GetType() == Ti.GetType())
            { 
                Ti = (Msg_system_time)e.Message; 
            }
            if (m.GetType() == Mc.GetType())
            {
                Mc = (Msg_mission_count)e.Message;
                MI = 0;
                GetMissionValues.RunWorkerAsync();
            }
            if (m.GetType() == Mi[0].GetType())
            {
                Mi[MI++] = (Msg_mission_item)e.Message;
                if (MI >= Mc.count)
                    MI = -1;
            }
            if (x > 0)
            {
                if (AvionicsDisplay.ActiveForm != null)
                    AvionicsDisplay.ActiveForm.Invalidate();
            }
        }

        private void Data(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int x = Serial.BytesToRead;
            byte[] b = new byte[x];
            for (int i = 0; i < x; i++)
                b[i] = (byte)Serial.ReadByte();
            Mv.ParseBytes(b);
        }

        private void ReadData(object sender, EventArgs e)
        {
            Serial.BaudRate = int.Parse(Baud.Text);
            Serial.PortName = Comm.Text;
            Serial.Open();
            btnConnect.Enabled = false;
            HeartBeat.RunWorkerAsync();
        }

        private void Dismiss(object sender, FormClosingEventArgs e)
        {
            if (Serial.IsOpen)
                Serial.Close();
        }

        private void Update(object sender, PaintEventArgs e)
        {
            if (At != null)
            {
                attitudeIndicator.SetAttitudeIndicatorParameters((At.pitch * 180 / 3.1415926), (At.roll * 180 / 3.1415926));
            }
            if (Gps != null)
            {
                    lbl_Latitude.Text = string.Format("{0:00.000000}", (float)(Gps.lat / 10000000.0f));
                    lbl_Latitude.Refresh();
                    lbl_Longitude.Text = string.Format("{0:00.000000}", (float)(Gps.lon / 10000000.0f));
                    lbl_Longitude.Refresh();

                if (Gps.lat != 0 && Gps.lon != 0)
                {
                    googleMap.AddPoint((float)Gps.lat / 10000000.0f, (float)Gps.lon / 10000000.0f);
                    double routeDis = googleMap.GetDistance();
                    lbl_Distance.Text = string.Format("{0:0.000}", routeDis);
                }
            }

            if(Ti != null)
            {
                txtTime.Text = ConvertTime(Ti.time_boot_ms);
                txtTime.Refresh();
            }

            if (Vfr != null)
            {
                lbl_Altitude.Text = string.Format("{0:00.00}", Vfr.alt);
                lbl_Altitude.Refresh();
                lbl_GroundSpeed.Text = string.Format("{0:f}", Vfr.groundspeed);
                lbl_GroundSpeed.Refresh();
                lbl_VerticalSpeed.Text = string.Format("{0:f}", Vfr.climb);
                lbl_VerticalSpeed.Refresh();
                headingIndicator.SetHeadingIndicatorParameters((int)Vfr.heading);
                lbl_Heading.Text = string.Format("{0:d}", Vfr.heading);
                lbl_Heading.Refresh();
            }
        }

        private void HeartB(object sender, DoWorkEventArgs e)
        {
            int sec;

            sec = 0;

            while (HB)
            {
                Msg_heartbeat hb = new Msg_heartbeat();
                if (sec != DateTime.Now.Second)
                {
                    hb.type = 6;
                    hb.system_status = 0;
                    hb.custom_mode = 0;
                    hb.base_mode = 0;
                    hb.autopilot = 0;

                    SendPacket(hb);
                    sec = DateTime.Now.Second;
                }
            }
        }

        private void SendPacket(MavlinkMessage m)
        {
            MavlinkPacket p = new MavlinkPacket();
            p.Message = m;
            p.SequenceNumber = (byte)Sequence;
            p.SystemId = 255;
            p.ComponentId = (byte)MAV_COMPONENT.MAV_COMP_ID_MISSIONPLANNER;
            byte[] b = Mv.Send(p);
            Serial.Write(b, 0, b.Length);
        }
        private void RecvMission(object sender, DoWorkEventArgs e)
        {
            int Pr = -1;

            while (MI >= 0)
            {
                if ((Pr != MI) && (MI >= 0))
                {
                    Msg_mission_request Mr = new Msg_mission_request();
                    Mr.seq = (byte)MI;
                    Mr.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
                    Mr.target_system = (byte)Systemid;
                    SendPacket(Mr);
                    Pr = MI;
                }
            }
        }

        static string ConvertTime(uint milisecs)
        {
            uint hours = milisecs / 3600000;
            uint mins = (milisecs % 3600000) / 60000;
            return string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3}", hours, mins, milisecs % 60000 / 1000, milisecs % 1000);
        } 
    }
}
