using static System.Net.Mime.MediaTypeNames;

namespace BhamBands.Models
{
    public class Attraction
    {
        public string name { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public bool test { get; set; }
        public string locale { get; set; }
        public IList<Image> images { get; set; }
        
    }
}
