using APA202Api.Data;
using APA202Api.Dto;
using APA202Api.Dto.Order;
using APA202Api.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APA202Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController(AppDbContext dbContext, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetOrders()
    {
        var orders = await dbContext.Orders
            .Include(o => o.Items)
            .ThenInclude(oi => oi.Product)
            .ProjectTo<OrderDto>(mapper.ConfigurationProvider)
            .ToListAsync();
        return Ok(ResponseModel<List<OrderDto>>.Success(orders));
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder(OrderCreateDto orderCreateDto)
    {
        List<OrderItem> orderItems = [];
        foreach (var item in orderCreateDto.Items)
        {
            var product = await dbContext.Products.FirstOrDefaultAsync(x => x.Id == item.ProductId);
            if (product is null)
                return BadRequest(ResponseModel<object>.Error("Mehsul tapilmadi"));
            if(product.Stock < item.Quantity)
                return BadRequest(ResponseModel<object>.Error("Stok kifayet deyil"));
            product.Stock -= item.Quantity;
            OrderItem orderItem = new()
            {
                ProductId = product.Id,
                Price = product.Price,
                Quantity = item.Quantity
            };
            orderItems.Add(orderItem);
        }

        Order newOrder = new()
        {
            TotalPrice = orderItems.Sum(x => x.Quantity * x.Price),
            Items = orderItems
        };
        await dbContext.Orders.AddAsync(newOrder);
        await dbContext.SaveChangesAsync();
        return Ok(ResponseModel<object>.Success());
    }
}
