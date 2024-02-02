namespace BhamBands.Models
{
    public class Dates
    {
        public int Id { get; set; } // Primary key
        public Start start { get; set; }
        public string timezone { get; set; }
        public Status status { get; set; }
    }
}
