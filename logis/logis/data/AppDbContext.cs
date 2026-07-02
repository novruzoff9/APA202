using logis.Models;
using Microsoft.EntityFrameworkCore;

namespace logis.data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Service> Services{ get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
