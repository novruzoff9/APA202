using APA202Api.Data;
using APA202Api.Dto;
using APA202Api.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace APA202Api.Services;

public interface IProductService
{
    Task<ResponseModel<int>> CreateProductAsync(ProductCreateDto newProductDto);
    Task<ResponseModel<List<ProductDto>>> GetAllAsync();
}

public class ProductService(
    IMapper mapper,
    AppDbContext dbContext,
    IValidator<ProductCreateDto> productValidator
    ) : IProductService
{
    public async Task<ResponseModel<int>> CreateProductAsync(ProductCreateDto newProductDto)
    {
        var validationResult = await productValidator.ValidateAsync(newProductDto);
        if (!validationResult.IsValid)
        {
            var errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            return ResponseModel<int>.Error(errors);
        }
        Product newProduct = mapper.Map<Product>(newProductDto);
        await dbContext.Products.AddAsync(newProduct);
        await dbContext.SaveChangesAsync();
        return ResponseModel<int>.Success(newProduct.Id);
    }

    public async Task<ResponseModel<List<ProductDto>>> GetAllAsync()
    {
        var datas = await dbContext.Products
            .ProjectTo<ProductDto>(mapper.ConfigurationProvider)
            .ToListAsync();
        return ResponseModel<List<ProductDto>>.Success(datas);
    }
}
