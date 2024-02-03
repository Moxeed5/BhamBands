using Microsoft.AspNetCore.Mvc;
using BhamBands.Services;
using System.Threading.Tasks;

public class TicketmasterController : Controller
{
    private readonly TicketmasterService _ticketmasterService;

    public TicketmasterController(TicketmasterService ticketmasterService)
    {
        _ticketmasterService = ticketmasterService;
    }

    public async Task<IActionResult> FetchEvents()
    {
        var events = await _ticketmasterService.GetEventsAsync();
        foreach (var eventItem in events)
        {
            Console.WriteLine($"Name: {eventItem.name}");
            // Output other details as required
        }

        // Since there's no view, simply return a basic response or redirect as needed
        return Content("Events fetched. Check the console output.");
    }
}

