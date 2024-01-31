namespace BhamBands.Models
{
    public class Venue
    {
        public int VenueId { get; set; }
        public string Name { get; set; }
        // ... other properties ...

        // Navigation back to Event
        public List<Event> Events { get; set; }
    }

}
