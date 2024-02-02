namespace BhamBands.Models
{
    public class Image
    {
        public int Id { get; set; } // Primary key
        public string ratio { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool fallback { get; set; }
    }
}
