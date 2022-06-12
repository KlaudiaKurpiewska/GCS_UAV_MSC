using System.Collections.Generic;
using System.Linq;

namespace Avionics
{
    class LogAttributesContainer
    {
        public SortedDictionary<double, GPSDataModel> GpsDataDictionary;
        public SortedDictionary<double, ATTDataModel> AttDataDictionary;

        public double GetMaxTime()
        {
            double gpsDataMaxTime = GpsDataDictionary != null && GpsDataDictionary.Count > 0 ? GpsDataDictionary.Last().Value.TimeMS : 0;
            double attDataMaxTime = AttDataDictionary != null && AttDataDictionary.Count > 0 ? AttDataDictionary.Last().Value.TimeMS : 0;

            double maxTime = gpsDataMaxTime > attDataMaxTime ? gpsDataMaxTime : attDataMaxTime;
            return maxTime;
        }

        public double GetMinTime()
        {
            double gpsDataMaxTime = GpsDataDictionary != null && GpsDataDictionary.Count > 0 ? GpsDataDictionary.First().Value.TimeMS : 0;
            double attDataMaxTime = AttDataDictionary != null && AttDataDictionary.Count > 0 ? AttDataDictionary.First().Value.TimeMS : 0;

            double maxTime = gpsDataMaxTime < attDataMaxTime ? gpsDataMaxTime : attDataMaxTime;
            return maxTime;
        }

        public LogAttributesValues GenerateClosestData(double time)
        {
            var gpsDataModelKey = GpsDataDictionary.Keys.FirstOrDefault((key) => key >= time ? true : false);
            var attDataModelKey = AttDataDictionary.Keys.FirstOrDefault((key) => key >= time ? true : false);

            return new LogAttributesValues()
            {
                GPSDataModel = GpsDataDictionary.Keys.Contains(gpsDataModelKey) ? GpsDataDictionary[gpsDataModelKey] : null,
                ATTDataModel = AttDataDictionary.Keys.Contains(attDataModelKey) ? AttDataDictionary[attDataModelKey] : null
            };
        }
    }

    class LogAttributesValues
    {
        public GPSDataModel GPSDataModel;
        public ATTDataModel ATTDataModel;
    }
}
