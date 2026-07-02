using Apa202Onion.Application.Dtos.Category;
using Apa202Onion.Application.Interfaces;
using Apa202Onion.Application.Repositories;
using Apa202Onion.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apa202Onion.Application.Services;

public interface ICategoryService
{
    Task<Guid> CreateCategoryAsync(CreateCategoryDto createCategoryDto);
    Task<List<Category>> GetAllAsync();
}

public class CategoryService(
    IAppDbContext dbContext
    ) : ICategoryService
{
    public async Task<Guid> CreateCategoryAsync(CreateCategoryDto createCategoryDto)
    {
        Category newCategory = new()
        {
            Name = createCategoryDto.Name
        };
        await dbContext.Categories.ToListAsync();
        await dbContext.SaveChangesAsync();
        return newCategory.Id;
    }

    public Task<List<Category>> GetAllAsync()
    {
        var data = categoryRepository.GetAllAsync();
        return data;
    }
}