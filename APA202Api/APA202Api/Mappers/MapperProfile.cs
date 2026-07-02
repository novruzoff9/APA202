using APA202Api.Dto;
using APA202Api.Dto.Account;
using APA202Api.Dto.Order;
using APA202Api.Models;
using AutoMapper;

namespace APA202Api.Mappers;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<ProductCreateDto, Product>();
        CreateMap<CategoryCreateDto, Category>();

        CreateMap<Product, ProductDto>().ReverseMap();

        //CreateMap<OrderItemCreateDto, OrderItem>();
        //CreateMap<OrderCreateDto, Order>();

        CreateMap<Order, OrderDto>();
        CreateMap<OrderItem, OrderItemDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Product.Name))
            .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.Quantity * src.Price));

        CreateMap<RegisterDto, AppUser>()
            .ForMember(dest => dest.PasswordHash, opt => opt.Ignore());
    }
}
