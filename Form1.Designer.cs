
using System.Windows.Forms;

namespace Avionics
{
    partial class AvionicsDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_Distance = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbl_VerticalSpeed = new System.Windows.Forms.Label();
            this.lbl_GroundSpeed = new System.Windows.Forms.Label();
            this.lbl_Altitude = new System.Windows.Forms.Label();
            this.lbl_Longitude = new System.Windows.Forms.Label();
            this.lbl_Latitude = new System.Windows.Forms.Label();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Bar = new System.Windows.Forms.Label();
            this.Distance = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.FlightTime = new System.Windows.Forms.Label();
            this.Longitude = new System.Windows.Forms.Label();
            this.Latitude = new System.Windows.Forms.Label();
            this.VerticalSpeed = new System.Windows.Forms.Label();
            this.GroundSpeed = new System.Windows.Forms.Label();
            this.Altitude = new System.Windows.Forms.Label();
            this.tlo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Baud = new System.Windows.Forms.ComboBox();
            this.lbl_Baud = new System.Windows.Forms.Label();
            this.lbl_Comm = new System.Windows.Forms.Label();
            this.Comm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Log = new System.Windows.Forms.Label();
            this.lbl_Choose = new System.Windows.Forms.Label();
            this.cmB_UAV = new System.Windows.Forms.ComboBox();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.txtLoad = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnClose3 = new System.Windows.Forms.Button();
            this.chckVertSpeed = new System.Windows.Forms.CheckBox();
            this.chckGrSpeed = new System.Windows.Forms.CheckBox();
            this.chckRoll = new System.Windows.Forms.CheckBox();
            this.chckPitch = new System.Windows.Forms.CheckBox();
            this.chckAltitude = new System.Windows.Forms.CheckBox();
            this.label_parameters = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.GetMissionValues = new System.ComponentModel.BackgroundWorker();
            this.HeartBeat = new System.ComponentModel.BackgroundWorker();
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.headingIndicator = new Avionics.HeadingIndicator();
            this.attitudeIndicator = new Avionics.AttitudeIndicator();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1924, 1055);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.lbl_Distance);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.lbl_VerticalSpeed);
            this.tabPage1.Controls.Add(this.lbl_GroundSpeed);
            this.tabPage1.Controls.Add(this.lbl_Altitude);
            this.tabPage1.Controls.Add(this.lbl_Longitude);
            this.tabPage1.Controls.Add(this.lbl_Latitude);
            this.tabPage1.Controls.Add(this.lbl_Heading);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.Bar);
            this.tabPage1.Controls.Add(this.Distance);
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Controls.Add(this.txtTime);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.FlightTime);
            this.tabPage1.Controls.Add(this.Longitude);
            this.tabPage1.Controls.Add(this.Latitude);
            this.tabPage1.Controls.Add(this.VerticalSpeed);
            this.tabPage1.Controls.Add(this.GroundSpeed);
            this.tabPage1.Controls.Add(this.Altitude);
            this.tabPage1.Controls.Add(this.headingIndicator);
            this.tabPage1.Controls.Add(this.tlo);
            this.tabPage1.Controls.Add(this.attitudeIndicator);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.map);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1916, 1019);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data visualization";
            // 
            // lbl_Distance
            // 
            this.lbl_Distance.AutoSize = true;
            this.lbl_Distance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distance.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Distance.Location = new System.Drawing.Point(1799, 893);
            this.lbl_Distance.Name = "lbl_Distance";
            this.lbl_Distance.Size = new System.Drawing.Size(64, 32);
            this.lbl_Distance.TabIndex = 43;
            this.lbl_Distance.Text = "N/A";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1194, 954);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 38);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Black;
            this.btnConnect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnConnect.Location = new System.Drawing.Point(1174, 862);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(147, 77);
            this.btnConnect.TabIndex = 36;
            this.btnConnect.Text = "CONNECT IN REAL TIME";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.ReadData);
            // 
            // lbl_VerticalSpeed
            // 
            this.lbl_VerticalSpeed.AutoSize = true;
            this.lbl_VerticalSpeed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VerticalSpeed.ForeColor = System.Drawing.Color.Lime;
            this.lbl_VerticalSpeed.Location = new System.Drawing.Point(99, 502);
            this.lbl_VerticalSpeed.Name = "lbl_VerticalSpeed";
            this.lbl_VerticalSpeed.Size = new System.Drawing.Size(64, 32);
            this.lbl_VerticalSpeed.TabIndex = 42;
            this.lbl_VerticalSpeed.Text = "N/A";
            // 
            // lbl_GroundSpeed
            // 
            this.lbl_GroundSpeed.AutoSize = true;
            this.lbl_GroundSpeed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GroundSpeed.ForeColor = System.Drawing.Color.Lime;
            this.lbl_GroundSpeed.Location = new System.Drawing.Point(99, 411);
            this.lbl_GroundSpeed.Name = "lbl_GroundSpeed";
            this.lbl_GroundSpeed.Size = new System.Drawing.Size(64, 32);
            this.lbl_GroundSpeed.TabIndex = 41;
            this.lbl_GroundSpeed.Text = "N/A";
            // 
            // lbl_Altitude
            // 
            this.lbl_Altitude.AutoSize = true;
            this.lbl_Altitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Altitude.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Altitude.Location = new System.Drawing.Point(99, 315);
            this.lbl_Altitude.Name = "lbl_Altitude";
            this.lbl_Altitude.Size = new System.Drawing.Size(64, 32);
            this.lbl_Altitude.TabIndex = 40;
            this.lbl_Altitude.Text = "N/A";
            // 
            // lbl_Longitude
            // 
            this.lbl_Longitude.AutoSize = true;
            this.lbl_Longitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Longitude.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Longitude.Location = new System.Drawing.Point(53, 680);
            this.lbl_Longitude.Name = "lbl_Longitude";
            this.lbl_Longitude.Size = new System.Drawing.Size(64, 32);
            this.lbl_Longitude.TabIndex = 39;
            this.lbl_Longitude.Text = "N/A";
            // 
            // lbl_Latitude
            // 
            this.lbl_Latitude.AutoSize = true;
            this.lbl_Latitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Latitude.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Latitude.Location = new System.Drawing.Point(53, 592);
            this.lbl_Latitude.Name = "lbl_Latitude";
            this.lbl_Latitude.Size = new System.Drawing.Size(64, 32);
            this.lbl_Latitude.TabIndex = 38;
            this.lbl_Latitude.Text = "N/A";
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heading.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Heading.Location = new System.Drawing.Point(110, 982);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(64, 32);
            this.lbl_Heading.TabIndex = 4;
            this.lbl_Heading.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1721, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "WAITING FOR VIDEO";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox3.Location = new System.Drawing.Point(1679, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(355, 216);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // Bar
            // 
            this.Bar.AutoSize = true;
            this.Bar.BackColor = System.Drawing.Color.Black;
            this.Bar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar.ForeColor = System.Drawing.Color.Snow;
            this.Bar.Location = new System.Drawing.Point(1521, 949);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(247, 23);
            this.Bar.TabIndex = 31;
            this.Bar.Text = "Progress bar for log file:";
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.BackColor = System.Drawing.Color.Black;
            this.Distance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distance.ForeColor = System.Drawing.Color.Snow;
            this.Distance.Location = new System.Drawing.Point(1765, 862);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(150, 23);
            this.Distance.TabIndex = 28;
            this.Distance.Text = "Distance [km]:";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Snow;
            this.progressBar.ForeColor = System.Drawing.Color.LawnGreen;
            this.progressBar.Location = new System.Drawing.Point(1524, 984);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(461, 23);
            this.progressBar.TabIndex = 27;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Black;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Lime;
            this.txtTime.Location = new System.Drawing.Point(1523, 893);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(221, 32);
            this.txtTime.TabIndex = 25;
            this.txtTime.Text = "00:00:00:00";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Black;
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(1360, 954);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 38);
            this.btnStop.TabIndex = 24;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Yellow;
            this.btnStart.Location = new System.Drawing.Point(1343, 862);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 77);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "READ LOG FILE";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FlightTime
            // 
            this.FlightTime.AutoSize = true;
            this.FlightTime.BackColor = System.Drawing.Color.Black;
            this.FlightTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightTime.ForeColor = System.Drawing.Color.Snow;
            this.FlightTime.Location = new System.Drawing.Point(1521, 862);
            this.FlightTime.Name = "FlightTime";
            this.FlightTime.Size = new System.Drawing.Size(225, 23);
            this.FlightTime.TabIndex = 11;
            this.FlightTime.Text = "Flight Time[h:m:s:ms]:";
            // 
            // Longitude
            // 
            this.Longitude.AutoSize = true;
            this.Longitude.BackColor = System.Drawing.Color.Black;
            this.Longitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Longitude.ForeColor = System.Drawing.Color.Snow;
            this.Longitude.Location = new System.Drawing.Point(83, 643);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(114, 23);
            this.Longitude.TabIndex = 10;
            this.Longitude.Text = "Longitude:";
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.BackColor = System.Drawing.Color.Black;
            this.Latitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Latitude.ForeColor = System.Drawing.Color.Snow;
            this.Latitude.Location = new System.Drawing.Point(92, 550);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(96, 23);
            this.Latitude.TabIndex = 9;
            this.Latitude.Text = "Latitude:";
            // 
            // VerticalSpeed
            // 
            this.VerticalSpeed.AutoSize = true;
            this.VerticalSpeed.BackColor = System.Drawing.Color.Black;
            this.VerticalSpeed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerticalSpeed.ForeColor = System.Drawing.Color.Snow;
            this.VerticalSpeed.Location = new System.Drawing.Point(33, 457);
            this.VerticalSpeed.Name = "VerticalSpeed";
            this.VerticalSpeed.Size = new System.Drawing.Size(214, 23);
            this.VerticalSpeed.TabIndex = 8;
            this.VerticalSpeed.Text = "Vertical Speed [m/s]:";
            // 
            // GroundSpeed
            // 
            this.GroundSpeed.AutoSize = true;
            this.GroundSpeed.BackColor = System.Drawing.Color.Black;
            this.GroundSpeed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroundSpeed.ForeColor = System.Drawing.Color.Snow;
            this.GroundSpeed.Location = new System.Drawing.Point(34, 364);
            this.GroundSpeed.Name = "GroundSpeed";
            this.GroundSpeed.Size = new System.Drawing.Size(212, 23);
            this.GroundSpeed.TabIndex = 7;
            this.GroundSpeed.Text = "Ground Speed [m/s]:";
            // 
            // Altitude
            // 
            this.Altitude.AutoSize = true;
            this.Altitude.BackColor = System.Drawing.Color.Black;
            this.Altitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Altitude.ForeColor = System.Drawing.Color.Snow;
            this.Altitude.Location = new System.Drawing.Point(69, 271);
            this.Altitude.Name = "Altitude";
            this.Altitude.Size = new System.Drawing.Size(134, 23);
            this.Altitude.TabIndex = 6;
            this.Altitude.Text = "Altitude - rel:";
            // 
            // tlo
            // 
            this.tlo.BackColor = System.Drawing.Color.Black;
            this.tlo.Location = new System.Drawing.Point(-4, 251);
            this.tlo.Name = "tlo";
            this.tlo.Size = new System.Drawing.Size(284, 502);
            this.tlo.TabIndex = 5;
            this.tlo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(1153, 846);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(953, 176);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.EmptyTileColor = System.Drawing.Color.Snow;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(3, 3);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1910, 1013);
            this.map.TabIndex = 26;
            this.map.Zoom = 0D;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.Baud);
            this.tabPage2.Controls.Add(this.lbl_Baud);
            this.tabPage2.Controls.Add(this.lbl_Comm);
            this.tabPage2.Controls.Add(this.Comm);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lbl_Log);
            this.tabPage2.Controls.Add(this.lbl_Choose);
            this.tabPage2.Controls.Add(this.cmB_UAV);
            this.tabPage2.Controls.Add(this.btnClose2);
            this.tabPage2.Controls.Add(this.txtLoad);
            this.tabPage2.Controls.Add(this.btnLoad);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1916, 1019);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            // 
            // Baud
            // 
            this.Baud.FormattingEnabled = true;
            this.Baud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.Baud.Location = new System.Drawing.Point(240, 241);
            this.Baud.Name = "Baud";
            this.Baud.Size = new System.Drawing.Size(121, 28);
            this.Baud.TabIndex = 42;
            // 
            // lbl_Baud
            // 
            this.lbl_Baud.AutoSize = true;
            this.lbl_Baud.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Baud.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbl_Baud.Location = new System.Drawing.Point(143, 241);
            this.lbl_Baud.Name = "lbl_Baud";
            this.lbl_Baud.Size = new System.Drawing.Size(68, 23);
            this.lbl_Baud.TabIndex = 41;
            this.lbl_Baud.Text = "BAUD";
            // 
            // lbl_Comm
            // 
            this.lbl_Comm.AutoSize = true;
            this.lbl_Comm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comm.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbl_Comm.Location = new System.Drawing.Point(92, 153);
            this.lbl_Comm.Name = "lbl_Comm";
            this.lbl_Comm.Size = new System.Drawing.Size(119, 23);
            this.lbl_Comm.TabIndex = 40;
            this.lbl_Comm.Text = "COM PORT";
            // 
            // Comm
            // 
            this.Comm.Location = new System.Drawing.Point(240, 153);
            this.Comm.Name = "Comm";
            this.Comm.Size = new System.Drawing.Size(100, 28);
            this.Comm.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(173, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "REAL TIME";
            // 
            // lbl_Log
            // 
            this.lbl_Log.AutoSize = true;
            this.lbl_Log.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Log.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Log.Location = new System.Drawing.Point(1362, 48);
            this.lbl_Log.Name = "lbl_Log";
            this.lbl_Log.Size = new System.Drawing.Size(145, 32);
            this.lbl_Log.TabIndex = 37;
            this.lbl_Log.Text = "LOG FILE";
            // 
            // lbl_Choose
            // 
            this.lbl_Choose.AutoSize = true;
            this.lbl_Choose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Choose.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Choose.Location = new System.Drawing.Point(1195, 122);
            this.lbl_Choose.Name = "lbl_Choose";
            this.lbl_Choose.Size = new System.Drawing.Size(394, 20);
            this.lbl_Choose.TabIndex = 36;
            this.lbl_Choose.Text = "CHOOSE UAV MODEL (FLIGHT CONTROLLER):";
            // 
            // cmB_UAV
            // 
            this.cmB_UAV.FormattingEnabled = true;
            this.cmB_UAV.Items.AddRange(new object[] {
            "3DR SOLO (Pixhawk 2.0 Cube)",
            "3DR IRIS (mRo Pixhawk)"});
            this.cmB_UAV.Location = new System.Drawing.Point(1199, 163);
            this.cmB_UAV.Name = "cmB_UAV";
            this.cmB_UAV.Size = new System.Drawing.Size(458, 28);
            this.cmB_UAV.TabIndex = 35;
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.Color.Black;
            this.btnClose2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose2.ForeColor = System.Drawing.Color.White;
            this.btnClose2.Location = new System.Drawing.Point(19, 963);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(112, 38);
            this.btnClose2.TabIndex = 34;
            this.btnClose2.Text = "CLOSE";
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // txtLoad
            // 
            this.txtLoad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoad.Location = new System.Drawing.Point(1199, 217);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(632, 27);
            this.txtLoad.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoad.Location = new System.Drawing.Point(1199, 279);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(202, 60);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Log File";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage3.Controls.Add(this.btnClose3);
            this.tabPage3.Controls.Add(this.chckVertSpeed);
            this.tabPage3.Controls.Add(this.chckGrSpeed);
            this.tabPage3.Controls.Add(this.chckRoll);
            this.tabPage3.Controls.Add(this.chckPitch);
            this.tabPage3.Controls.Add(this.chckAltitude);
            this.tabPage3.Controls.Add(this.label_parameters);
            this.tabPage3.Controls.Add(this.chart);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1916, 1019);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Log Analysis";
            // 
            // btnClose3
            // 
            this.btnClose3.BackColor = System.Drawing.Color.Black;
            this.btnClose3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose3.ForeColor = System.Drawing.Color.White;
            this.btnClose3.Location = new System.Drawing.Point(8, 973);
            this.btnClose3.Name = "btnClose3";
            this.btnClose3.Size = new System.Drawing.Size(112, 38);
            this.btnClose3.TabIndex = 35;
            this.btnClose3.Text = "CLOSE";
            this.btnClose3.UseVisualStyleBackColor = false;
            this.btnClose3.Click += new System.EventHandler(this.btnClose3_Click);
            // 
            // chckVertSpeed
            // 
            this.chckVertSpeed.AutoSize = true;
            this.chckVertSpeed.Checked = true;
            this.chckVertSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckVertSpeed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckVertSpeed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chckVertSpeed.Location = new System.Drawing.Point(17, 434);
            this.chckVertSpeed.Name = "chckVertSpeed";
            this.chckVertSpeed.Size = new System.Drawing.Size(269, 32);
            this.chckVertSpeed.TabIndex = 6;
            this.chckVertSpeed.Text = "Vertical Speed [m/s]";
            this.chckVertSpeed.UseVisualStyleBackColor = true;
            this.chckVertSpeed.CheckedChanged += new System.EventHandler(this.chckVertSpeed_CheckedChanged);
            // 
            // chckGrSpeed
            // 
            this.chckGrSpeed.AutoSize = true;
            this.chckGrSpeed.Checked = true;
            this.chckGrSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckGrSpeed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckGrSpeed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chckGrSpeed.Location = new System.Drawing.Point(17, 354);
            this.chckGrSpeed.Name = "chckGrSpeed";
            this.chckGrSpeed.Size = new System.Drawing.Size(261, 32);
            this.chckGrSpeed.TabIndex = 5;
            this.chckGrSpeed.Text = "Ground speed [m/s]";
            this.chckGrSpeed.UseVisualStyleBackColor = true;
            this.chckGrSpeed.CheckedChanged += new System.EventHandler(this.chckGrSpeed_CheckedChanged);
            // 
            // chckRoll
            // 
            this.chckRoll.AutoSize = true;
            this.chckRoll.Checked = true;
            this.chckRoll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckRoll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckRoll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chckRoll.Location = new System.Drawing.Point(17, 277);
            this.chckRoll.Name = "chckRoll";
            this.chckRoll.Size = new System.Drawing.Size(145, 32);
            this.chckRoll.TabIndex = 4;
            this.chckRoll.Text = "Roll [deg]";
            this.chckRoll.UseVisualStyleBackColor = true;
            this.chckRoll.CheckedChanged += new System.EventHandler(this.chckRoll_CheckedChanged);
            // 
            // chckPitch
            // 
            this.chckPitch.AutoSize = true;
            this.chckPitch.Checked = true;
            this.chckPitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckPitch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckPitch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chckPitch.Location = new System.Drawing.Point(17, 203);
            this.chckPitch.Name = "chckPitch";
            this.chckPitch.Size = new System.Drawing.Size(159, 32);
            this.chckPitch.TabIndex = 3;
            this.chckPitch.Text = "Pitch [deg]";
            this.chckPitch.UseVisualStyleBackColor = true;
            this.chckPitch.CheckedChanged += new System.EventHandler(this.chckPitch_CheckedChanged);
            // 
            // chckAltitude
            // 
            this.chckAltitude.AutoSize = true;
            this.chckAltitude.Checked = true;
            this.chckAltitude.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckAltitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckAltitude.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chckAltitude.Location = new System.Drawing.Point(17, 123);
            this.chckAltitude.Name = "chckAltitude";
            this.chckAltitude.Size = new System.Drawing.Size(167, 32);
            this.chckAltitude.TabIndex = 2;
            this.chckAltitude.Text = "Altitude [m]";
            this.chckAltitude.UseVisualStyleBackColor = true;
            this.chckAltitude.CheckedChanged += new System.EventHandler(this.chckAltitude_CheckedChanged);
            // 
            // label_parameters
            // 
            this.label_parameters.AutoSize = true;
            this.label_parameters.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_parameters.ForeColor = System.Drawing.Color.White;
            this.label_parameters.Location = new System.Drawing.Point(12, 35);
            this.label_parameters.Name = "label_parameters";
            this.label_parameters.Size = new System.Drawing.Size(268, 56);
            this.label_parameters.TabIndex = 1;
            this.label_parameters.Text = "Choose parameters to\r\nvisualize on chart:";
            // 
            // chart
            // 
            chartArea1.AxisX.Interval = 30D;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Time [s]";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.Maximum = 20D;
            chartArea1.AxisY.Minimum = -20D;
            chartArea1.AxisY.Title = "Value";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.BorderWidth = 3;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(292, 0);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1624, 1019);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // GetMissionValues
            // 
            this.GetMissionValues.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RecvMission);
            // 
            // HeartBeat
            // 
            this.HeartBeat.DoWork += new System.ComponentModel.DoWorkEventHandler(this.HeartB);
            // 
            // Serial
            // 
            this.Serial.BaudRate = 57600;
            this.Serial.PortName = "COM16";
            this.Serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Data);
            // 
            // headingIndicator
            // 
            this.headingIndicator.Location = new System.Drawing.Point(0, 719);
            this.headingIndicator.Name = "headingIndicator";
            this.headingIndicator.Size = new System.Drawing.Size(280, 301);
            this.headingIndicator.TabIndex = 1;
            this.headingIndicator.Text = "headingIndicator1";
            // 
            // attitudeIndicator
            // 
            this.attitudeIndicator.Location = new System.Drawing.Point(0, 0);
            this.attitudeIndicator.Name = "attitudeIndicator";
            this.attitudeIndicator.Size = new System.Drawing.Size(280, 280);
            this.attitudeIndicator.TabIndex = 0;
            this.attitudeIndicator.Text = "attitudeIndicator1";
            // 
            // AvionicsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tabControl1);
            this.MinimizeBox = false;
            this.Name = "AvionicsDisplay";
            this.Text = "UAV Flight Data Visualization Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dismiss);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Update);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AttitudeIndicator attitudeIndicator;
        private HeadingIndicator headingIndicator;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox tlo;
        private System.Windows.Forms.Label FlightTime;
        private System.Windows.Forms.Label Longitude;
        private System.Windows.Forms.Label Latitude;
        private System.Windows.Forms.Label VerticalSpeed;
        private System.Windows.Forms.Label GroundSpeed;
        private System.Windows.Forms.Label Altitude;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtTime;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label Bar;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_parameters;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.CheckBox chckVertSpeed;
        private System.Windows.Forms.CheckBox chckGrSpeed;
        private System.Windows.Forms.CheckBox chckRoll;
        private System.Windows.Forms.CheckBox chckPitch;
        private System.Windows.Forms.CheckBox chckAltitude;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Button btnClose3;
        private System.Windows.Forms.ComboBox cmB_UAV;
        private System.Windows.Forms.Label lbl_Choose;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox Baud;
        private System.Windows.Forms.Label lbl_Baud;
        private System.Windows.Forms.Label lbl_Comm;
        private System.Windows.Forms.TextBox Comm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Log;
        private System.ComponentModel.BackgroundWorker GetMissionValues;
        private System.ComponentModel.BackgroundWorker HeartBeat;
        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.Label lbl_Heading;
        private System.Windows.Forms.Label lbl_Altitude;
        private System.Windows.Forms.Label lbl_Longitude;
        private System.Windows.Forms.Label lbl_Latitude;
        private Label lbl_VerticalSpeed;
        private Label lbl_GroundSpeed;
        private Label lbl_Distance;
    }
}

