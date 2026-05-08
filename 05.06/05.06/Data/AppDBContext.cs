using _05._06.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace _05._06.Data
{
    public class AppDBContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        
    }
}
