using APA202Api.Models.Base;

namespace APA202Api.Models;

public class Order : BaseEntity
{
    public decimal TotalPrice { get; set; }
    public List<OrderItem> Items { get; set; }
}
