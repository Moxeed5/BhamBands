using BhamBands.Models;
using Microsoft.EntityFrameworkCore;

namespace BhamBands.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Event> Events { get; set; }
    }
}
