using LoggingKata.Interfaces;
using LoggingKata.Struct;

namespace LoggingKata.Classes
{
    public class TacoBell : ITrackable
    {
        public string Name { get; set; }
        public Point Location { get; set; }
    }
}
