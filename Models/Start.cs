namespace BhamBands.Models
{
    public class Start
    {
        public int Id { get; set; } // Primary key
        public string localDate { get; set; }
        public bool dateTBD { get; set; }
        public bool dateTBA { get; set; }
        public bool timeTBA { get; set; }
        public bool noSpecificTime { get; set; }
    }
}
