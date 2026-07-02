using Apa202Onion.Application.Repositories;
using Apa202Onion.Domain.Entities.Base;
using Apa202Onion.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Apa202Onion.Infrastructure.Repositories;

public class Repository<T>(AppDbContext dbContext) : IRepository<T> where T : BaseEntity
{
    private readonly DbSet<T> _table = dbContext.Set<T>();

    public async Task<Guid> AddAsync(T data)
    {
        await _table.AddAsync(data);
        return data.Id;
    }

    public async Task DeleteAsync(Guid id)
    {
        var data = await GetByIdAsync(id);
        _table.Remove(data);
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _table.ToListAsync();
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        var data = await _table.FirstOrDefaultAsync(x => x.Id == id);
        if (data is null)
            throw new Exception("data not found");
        return data;
    }

    public async Task SaveChangesAsync()
    {
        await dbContext.SaveChangesAsync();
    }

    public Task UpdateAsync(Guid id, T data)
    {
        throw new NotImplementedException();
    }
}
