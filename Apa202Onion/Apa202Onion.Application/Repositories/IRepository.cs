using Apa202Onion.Domain.Entities.Base;

namespace Apa202Onion.Application.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    Task<Guid> AddAsync(T data);
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
    Task DeleteAsync(Guid id);
    Task UpdateAsync(Guid id, T data);
    Task SaveChangesAsync();
}
