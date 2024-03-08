using System;
using GeoCoordinatePortable;
using LoggingKata.Interfaces;
using LoggingKata.Classes;
using System.IO;
using System.Linq;

namespace LoggingKata
{
    class Program
    {
        private GeoCoordinate geoCoordinate = new GeoCoordinate();
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

            double distanceApart;
            
            
            foreach (var loc in locations)
            {
                GeoCoordinate corA = new GeoCoordinate();
                
            }


            


        }
    }
}
