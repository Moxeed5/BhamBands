using BhamBands.Models;
using BhamBands.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; // Make sure you have this using directive for ILogger
using System.Diagnostics;
using System.Threading.Tasks; // Required for async Task

namespace BhamBands.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TicketmasterService _ticketmasterService; // Dependency

        // Consolidated constructor
        public HomeController(ILogger<HomeController> logger, TicketmasterService ticketmasterService)
        {
            _logger = logger;
            _ticketmasterService = ticketmasterService; // Initialize the service
        }

        //public async Task<IActionResult> Index()
        //{
        //    var events = await _ticketmasterService.GetEventsAsync(); // Fetch events asynchronously
        //    return View(events); // Pass the events to the Index view
        //}

        public async Task<IActionResult> Index(int page = 1)
        {
            var fetchResult = await _ticketmasterService.GetEventsAsync(page);
            ViewBag.CurrentPage = page;

            // Assuming EventViewModel is correctly expecting a list of events and a next page URL.
            // If EventViewModel is your model for the view, make sure it matches what the view expects.
            var viewModel = new EventViewModel
            {
                Events = fetchResult.Events,
                NextPageUrl = fetchResult.NextPageUrl
            };

            return View(viewModel);
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
