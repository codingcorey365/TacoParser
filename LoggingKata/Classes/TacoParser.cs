using LoggingKata.Interfaces;
using LoggingKata.Struct;

namespace LoggingKata.Classes
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            var cells = line.Split(',');

            if (cells.Length < 3)
            {
                // TODO
                // Log error message and return null
                return null;
            }

            var latitude = double.Parse(cells[0]);
            var longitude = double.Parse(cells[1]);
            var CityOfTacoBell = cells[2];

            var point = new Point();
            point.Longitude = longitude;
            point.Latitude = latitude;

            var tacoBell = new TacoBell();
            tacoBell.Location = point;
            tacoBell.Name = CityOfTacoBell;

            return tacoBell;
        }
    }
}
