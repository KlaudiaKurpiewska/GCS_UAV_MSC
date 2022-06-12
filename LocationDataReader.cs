using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Avionics
{
    public class GPSDataModel
    {
        public double TimeMS;
        public double Latitude;
        public double Longitude;
        public double Altitude;
        public double GroundSpeed;
        public double Course;
        public double VerticalSpeed;
    }

    public class ATTDataModel
    {
        public double TimeMS;
        public double Roll;
        public double Pitch;
        public double Yaw;
    }

    class LocationDataReader
    {
            public LogAttributesContainer ReadData(string fileName)
            {
                SortedDictionary<double, GPSDataModel> gpsDataDictionary = new SortedDictionary<double, GPSDataModel>();
                SortedDictionary<double, ATTDataModel> attDataDictionary = new SortedDictionary<double, ATTDataModel>();

                try
                {

                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            List<string> listDef = line.Split(',').Select(p => p.Trim()).ToList();

                            if (listDef[0].Equals("GPS"))
                            {
                                double timeMS = double.Parse(listDef[1], CultureInfo.InvariantCulture);
                            
                                
                                    timeMS /= 1000; //if time in microseconds then divide by 1000
                                
             
                                gpsDataDictionary.Add(timeMS, new GPSDataModel()
                                {
                                    TimeMS = (int)timeMS,
                                    Latitude = double.Parse(listDef[7], CultureInfo.InvariantCulture),
                                    Longitude = double.Parse(listDef[8], CultureInfo.InvariantCulture),
                                    Altitude = double.Parse(listDef[9], CultureInfo.InvariantCulture),
                                    GroundSpeed = double.Parse(listDef[10], CultureInfo.InvariantCulture),
                                    Course = double.Parse(listDef[11], CultureInfo.InvariantCulture),
                                    VerticalSpeed = double.Parse(listDef[12], CultureInfo.InvariantCulture),
                                });

                            }


                            if (listDef[0].Equals("ATT"))
                            {
                                double timeMS = double.Parse(listDef[1], CultureInfo.InvariantCulture);
                                timeMS /= 1000; //if time in microseconds then divide by 1000
                                attDataDictionary.Add(timeMS, new ATTDataModel()
                                {
                                    TimeMS = timeMS,
                                    Roll = double.Parse(listDef[3], CultureInfo.InvariantCulture),
                                    Pitch = double.Parse(listDef[5], CultureInfo.InvariantCulture),
                                    Yaw = double.Parse(listDef[7], CultureInfo.InvariantCulture),
                                });
                            }
                        }
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("The file could not be read");
                    Console.WriteLine(e.Message);
                }

                return new LogAttributesContainer() { GpsDataDictionary = gpsDataDictionary, AttDataDictionary = attDataDictionary};
            }


        public LogAttributesContainer ReadDataSolo(string fileName)
        {
            SortedDictionary<double, GPSDataModel> gpsDataDictionary = new SortedDictionary<double, GPSDataModel>();
            SortedDictionary<double, ATTDataModel> attDataDictionary = new SortedDictionary<double, ATTDataModel>();

            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        List<string> listDef = line.Split(',').Select(p => p.Trim()).ToList();

                        if (listDef[0].Equals("GPS"))
                        {
                            double timeMS = double.Parse(listDef[13], CultureInfo.InvariantCulture);

                            gpsDataDictionary.Add(timeMS, new GPSDataModel()
                            {
                                TimeMS = (int)timeMS,
                                Latitude = double.Parse(listDef[6], CultureInfo.InvariantCulture),
                                Longitude = double.Parse(listDef[7], CultureInfo.InvariantCulture),
                                Altitude = double.Parse(listDef[9], CultureInfo.InvariantCulture),
                                GroundSpeed = double.Parse(listDef[10], CultureInfo.InvariantCulture),
                                Course = double.Parse(listDef[11], CultureInfo.InvariantCulture),
                                VerticalSpeed = double.Parse(listDef[12], CultureInfo.InvariantCulture),
                            });
                        }
                        if (listDef[0].Equals("ATT"))
                        {
                            double timeMS = double.Parse(listDef[1], CultureInfo.InvariantCulture);
                            
                            attDataDictionary.Add(timeMS, new ATTDataModel()
                            {
                                TimeMS = timeMS,
                                Roll = double.Parse(listDef[3], CultureInfo.InvariantCulture),
                                Pitch = double.Parse(listDef[5], CultureInfo.InvariantCulture),
                                Yaw = double.Parse(listDef[7], CultureInfo.InvariantCulture),
                            });
                        }
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }

            return new LogAttributesContainer() { GpsDataDictionary = gpsDataDictionary, AttDataDictionary = attDataDictionary};
        }
    }


}
