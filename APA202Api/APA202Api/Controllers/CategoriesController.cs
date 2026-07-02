using APA202Api.Data;
using APA202Api.Dto;
using APA202Api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APA202Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles ="Admin")]
public class CategoriesController(AppDbContext dbContext, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var datas = await dbContext.Categories.ToListAsync();
        var response = ResponseModel<List<Category>>.Success(datas);
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var data = await dbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
        if(data is null)
            return NotFound(ResponseModel<Category>.Error("Category tapilmadi"));
        var response = ResponseModel<Category>.Success(data);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CategoryCreateDto categoryCreateDto)
    {
        Category newCategory = mapper.Map<Category>(categoryCreateDto);
        await dbContext.Categories.AddAsync(newCategory);
        await dbContext.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete(int? id)
    {
        if (id is null) return BadRequest();
        Category? category = dbContext.Categories.FirstOrDefault(x => x.Id == id);
        if (category is null) return NotFound();
        dbContext.Categories.Remove(category);
        return Ok();
    }

    [HttpPut]
    public IActionResult Update(int? id, Category updateCategory)
    {
        if (id is null) return BadRequest();
        Category? category = dbContext.Categories.FirstOrDefault(x => x.Id == id);
        if (category is null) return NotFound();
        category.Name = updateCategory.Name;
        return Ok();
    }
}
