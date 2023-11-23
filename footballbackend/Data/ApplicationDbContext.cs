using footballbackend.Models;
using Microsoft.EntityFrameworkCore;
using footballbackend.Models;

namespace footballbackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
