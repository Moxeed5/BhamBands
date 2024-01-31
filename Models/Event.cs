namespace BhamBands.Models
{
    public class Event
    {
        public string Id { get; set; }
        public string Name { get; set; }
        // ... other properties ...

        // Navigation properties
        public Venue Venue { get; set; }
        public List<TicketPrice> TicketPrices { get; set; }
    }

}
