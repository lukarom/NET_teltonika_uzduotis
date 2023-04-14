using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_teltonika_uzduotis.Models
{
    public class Histogram
    {
        public Columns Column { get; set; }
        public GpsData GpsData { get; set; }


        public void DrawHistogram(GpsData gpsData)
        {
            var gpsdata1 = gpsData.LoadJson();

            var satellites = gpsdata1.Select(gpsdata1 => gpsdata1.Satellites).ToList();

            for (int i = 0; i < 20; i++)
             {
                var count = satellites.Count(s => s == i);

                Columns column = new Columns();

                column.DrawColumn(count, i+1);               
            }
        }

        public void DrawSpeedData (GpsData gpsData)
        {
            var gpsdata1 = gpsData.LoadJson();

            var speed = gpsdata1.Select(gpsdata1 => gpsdata1.Speed).ToList();

            for (int i = 0; i < 20; i++)
            {

            }
        }
       
    }
}
