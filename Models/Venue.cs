using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using System.Diagnostics.Metrics;

namespace BhamBands.Models
{
    public class Venue
    {
        public string name { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public bool test { get; set; }
        public string locale { get; set; }
        public string postalCode { get; set; }
        public string timezone { get; set; }
        public City city { get; set; }
        public State state { get; set; }
        public Country country { get; set; }
        public Address address { get; set; }
        public Location location { get; set; }
        
    }
}
