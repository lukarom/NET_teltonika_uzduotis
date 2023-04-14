using NET_teltonika_uzduotis.Models;

namespace NET_teltonika_uzduotis
{
    internal class Program
    {

        static void Main(string[] args)
        {
            GpsData gpsdata = new GpsData();
            Histogram histogram = new Histogram();


            histogram.DrawHistogram(gpsdata);

            
        }
    }
}