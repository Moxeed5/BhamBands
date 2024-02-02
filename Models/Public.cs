namespace BhamBands.Models
{
    public class Public
    {
        public int Id { get; set; } // Primary key
        public DateTime startDateTime { get; set; }
        public bool startTBD { get; set; }
        public DateTime endDateTime
        {
            get; set;
        }
    }
}
