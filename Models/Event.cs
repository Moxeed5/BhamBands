namespace BhamBands.Models
{
        public class Event
        {
            public string name { get; set; }
            public string type { get; set; }
            public string id { get; set; }
            public bool test { get; set; }
            public string url { get; set; }
            public string locale { get; set; }
            public IList<Image> images { get; set; }
            
            public Dates dates { get; set; }
            
            
            public Embedded _embedded { get; set; }
        }

}
