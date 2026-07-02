using Apa202Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apa202Onion.Application.Repositories;

public interface ICategoryRepository : IRepository<Category>
{
    Task<int> GetCategories();
}
