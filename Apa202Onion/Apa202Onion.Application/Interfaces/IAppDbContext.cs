using Apa202Onion.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apa202Onion.Application.Interfaces;

public interface IAppDbContext
{
    DbSet<Category> Categories { get; set; }
    Task<int> SaveChangesAsync();
}
