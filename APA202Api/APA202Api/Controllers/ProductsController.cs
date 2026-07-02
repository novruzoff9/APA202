using APA202Api.Data;
using APA202Api.Dto;
using APA202Api.Models;
using APA202Api.Services;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APA202Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(
    AppDbContext dbContext, 
    IMapper mapper,
    IProductService productService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var response = await productService.GetAllAsync();
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var data = await dbContext.Products
            .ProjectTo<ProductDto>(mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(x => x.Id == id);
        return Ok(data);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductCreateDto newProductDto)
    {
        var response = await productService.CreateProductAsync(newProductDto);
        return StatusCode(response.StatusCode, response);
    }

    [HttpDelete]
    public IActionResult Delete(int? id)
    {
        if (id is null) return BadRequest();
        Product? product = dbContext.Products.FirstOrDefault(x => x.Id == id);
        if(product is null) return NotFound();
        dbContext.Products.Remove(product);
        return Ok();
    }

    [HttpPut]
    public IActionResult Update(int? id, Product updateProduct)
    {
        if (id is null) return BadRequest();
        Product? product = dbContext.Products.FirstOrDefault(x => x.Id == id);
        if (product is null) return NotFound();
        product.Name = updateProduct.Name;
        product.Price = updateProduct.Price;
        product.Category = updateProduct.Category;
        return Ok();
    }
}