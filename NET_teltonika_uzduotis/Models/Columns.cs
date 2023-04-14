using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_teltonika_uzduotis.Models
{
    public class Columns
    {
        public GpsData GpsData { get; set; }
        public int OrderNumber { get; set; }
        public int Size { get; set; }

        public void DrawColumn(int satellites, int sectionNumber)
        {
            var columnSection = "|";

            string column = new StringBuilder().Insert(0, columnSection, satellites).ToString();

            Console.WriteLine("Satellites:" + sectionNumber + Environment.NewLine + column + Environment.NewLine + "Hits:" + satellites + Environment.NewLine);       

        }               
            
        
    }
}
