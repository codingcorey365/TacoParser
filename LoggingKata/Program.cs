using GeoCoordinatePortable;
using LoggingKata.Classes;
using LoggingKata.Interfaces;
using System;
using System.IO;
using System.Linq;


namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        const string csvPath = "TacoBell-US-AL.csv";

        static void Main(string[] args)
        {
            logger.LogInfo("Log initialized");

            var lines = File.ReadAllLines(csvPath);

            logger.LogInfo($"Lines: {lines[0]}");

            var parser = new TacoParser();

            var locations = lines.Select(parser.Parse).ToArray();

            // TODO: Create an Itrackable and set to null
            ITrackable storeLocationA = null;
            ITrackable storeLocationB = null;


            double distanceApart = 0;

            // TODO: Make foreach loop for locations
            foreach (var locA in locations)
            {
                GeoCoordinate corA = new GeoCoordinate();

                // TODO: Set location for locA
                corA.Latitude = locA.Location.Latitude;
                corA.Longitude = locA.Location.Longitude;

                // TODO: Make nested foreach loop for locations
                foreach (var locB in locations)
                {
                    GeoCoordinate corB = new GeoCoordinate();

                    // TODO: Set location for locB
                    corB.Latitude = locB.Location.Latitude;
                    corB.Longitude = locB.Location.Longitude;

                    // TODO: Compare distance of locA and locB
                    var newdistance = corA.GetDistanceTo(corB);

                    if (newdistance > distanceApart)
                    {
                        // TODO: Update distance if greater than itself
                        distanceApart = newdistance;

                        // TODO: Associate Store to location  
                        storeLocationA = locA;
                        storeLocationB = locB;
                    }

                }
            }

            Console.WriteLine("test");
            Console.WriteLine(storeLocationA.Name);
            Console.WriteLine(storeLocationB.Name);
        }
    }
}
