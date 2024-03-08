using LoggingKata.Struct;

namespace LoggingKata.Interfaces
{
    public interface ITrackable
    {
        public string Name { get; set; }
        Point Location { get; set; }
    }
}