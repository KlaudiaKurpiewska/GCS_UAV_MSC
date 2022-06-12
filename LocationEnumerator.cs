using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Avionics
{
    class LocationEnumerator
    {
        public EventHandler<Location> changeEvent;
        public static List<Location> StartEnumeration(LocationDataTable locationData)
        {
            int maxRows = 0;
            int gpsDataRowsCount = locationData.gpsData.Rows.Count;
            int attDataRowsCount = locationData.attData.Rows.Count;
            int currDataRowsCount = locationData.currData.Rows.Count;

            if (gpsDataRowsCount > maxRows)
            {
                maxRows = gpsDataRowsCount;
            }
            if (attDataRowsCount > maxRows)
            {
                maxRows = attDataRowsCount;
            }
            List<Location> listGPSdata = new List<Location>();

            for (int i = 0; i < maxRows; i++)
            {
                if (i < gpsDataRowsCount)
                {

                }
                if (i < attDataRowsCount)
                {

                }
            }
            foreach (DataRow row in locationData.Rows)
            {
                listGPSdata.Add(new Location() { lat = Convert.ToDouble(row["Lat"]), lon = Convert.ToDouble(row["Lon"]) });

            }
            return listGPSdata;
        }
    }
}
