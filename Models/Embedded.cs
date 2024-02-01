using Microsoft.Extensions.Logging;

namespace BhamBands.Models
{
    public class Embedded
    {
        public IList<Event> events { get; set; }
        public IList<Venue> venues { get; set; }
        public IList<Attraction> attractions { get; set; }
    }
}
