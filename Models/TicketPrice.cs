namespace BhamBands.Models
{
    public class TicketPrice
    {
        public int TicketPriceId { get; set; }
        public string EventId { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }

        // Navigation back to Event
        public Event Event { get; set; }
    }

}
