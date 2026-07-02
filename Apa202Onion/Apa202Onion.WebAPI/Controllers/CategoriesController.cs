using Apa202Onion.Application.Dtos.Category;
using Apa202Onion.Application.Services;
using Apa202Onion.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Apa202Onion.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController(
    ICategoryService categoryService
    ) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var data = await categoryService.GetAllAsync();
        return Ok(data);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCategoryDto categoryCreateDto)
    {
        var data = await categoryService.CreateCategoryAsync(categoryCreateDto);
        return Ok(data);
    }
}
