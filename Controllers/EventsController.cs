using BhamBands.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BhamBands.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public EventsController(AppDbContext appDbContext) 
        {
        }
    }
}
