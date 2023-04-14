using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NET_teltonika_uzduotis.Models
{
    public class GpsData
    {
        public List<GpsData>? LoadJson()
        {
            using (StreamReader r = new StreamReader("2019-07.json"))
            {
                string json = r.ReadToEnd();
                List<GpsData>? gpsData = JsonConvert.DeserializeObject<List<GpsData>>(json);
                
                return gpsData;
            }
        }
        public List<GpsData>? LoadCSV()
        {

            var result = File.ReadAllLines("2019-08.csv")
                .Select(line => line.Split(','))
                .Select(x => new GpsData
                {
                    Latitude = x[0],
                    Longitude = x[1],
                    GpsTime = x[2],
                    Speed = int.Parse(x[3]),
                    Angle = int.Parse(x[4]),
                    Altitude = int.Parse(x[5]),
                    Satellites = int.Parse(x[6])
                })
                .ToList();

            return result;

        }





        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? GpsTime { get; set; }
        public int Speed { get; set; }
        public int Angle { get; set; }
        public int Altitude { get; set; }
        public int Satellites { get; set; }

       

    }

    
}
