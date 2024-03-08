using System;
using GeoCoordinatePortable;
using LoggingKata.Interfaces;
using LoggingKata.Classes;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

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
            
            ITrackable storeLocationA = null;
            ITrackable storeLocationB = null;


            double distanceApart = 0;

            foreach (var locA in locations)
            {
                GeoCoordinate corA = new GeoCoordinate();

                corA.Latitude = locA.Location.Latitude;
                corA.Longitude = locA.Location.Longitude;

                foreach (var locB in locations)
                {
                    GeoCoordinate corB = new GeoCoordinate();

                    corB.Latitude = locB.Location.Latitude;
                    corB.Longitude = locB.Location.Longitude; 
                    

                    var newdistance = corA.GetDistanceTo(corB);
                    
                    if (newdistance > distanceApart)
                    {
                        distanceApart = newdistance;

                        storeLocationA = locA;
                        storeLocationB = locB;
                    }

                }
            }

            Console.WriteLine(storeLocationA.Name);
            Console.WriteLine(storeLocationB.Name);
        }
    }
}
