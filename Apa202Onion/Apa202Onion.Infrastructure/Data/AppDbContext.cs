using Apa202Onion.Application.Interfaces;
using Apa202Onion.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apa202Onion.Infrastructure.Data;

public class AppDbContext(
    DbContextOptions<AppDbContext> options
    ) : DbContext(options), IAppDbContext
{
    public DbSet<Category> Categories { get; set; }

    public async Task<int> SaveChangesAsync()
    {
        return await base.SaveChangesAsync();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
