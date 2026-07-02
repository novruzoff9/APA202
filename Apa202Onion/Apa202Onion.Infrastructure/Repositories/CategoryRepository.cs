using Apa202Onion.Application.Repositories;
using Apa202Onion.Domain.Entities;
using Apa202Onion.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apa202Onion.Infrastructure.Repositories;

public class CategoryRepository(AppDbContext dbContext
    ) : Repository<Category>(dbContext), ICategoryRepository
{
    public Task<int> GetCategories()
    {
        throw new NotImplementedException();
    }
}
