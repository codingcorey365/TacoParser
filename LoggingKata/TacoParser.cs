namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            // Done
            // Calls method to Console.WriteLine string in the parameter.
            logger.LogInfo("Begin parsing");

            // Done
            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // Done
            // If your array's Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // TODO
                // Log error message and return null
                return null; 
            }

            // Done
            // Grab the latitude from your array at index 0
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            var latitude = double.Parse(cells[0]);

            // Done
            // Grab the longitude from your array at index 1
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            var longitude = double.Parse(cells[1]);

            // Done
            // Grab the name from your array at index 2
            var CityOfTacoBell = cells[2];

            // Done
            // Create an instance of the Point Struct
            // Set the values of the point correctly (Latitude and Longitude) 
            var point = new Point();
            point.Longitude = longitude;
            point.Latitude = latitude;

            // Done
            // Create a TacoBell class that conforms to ITrackable
            // Create an instance of the TacoBell class
            // Set the values of the class correctly (Name and Location)
            var tacoBellClass = new TacoBell();
            tacoBellClass.Location = point;
            tacoBellClass.Name = CityOfTacoBell;
            

            // Done
            // Return the instance of your TacoBell class, because it conforms to ITrackable
            return tacoBellClass;
            

            
        }
    }
}
