using APA202Api.Models.Base;

namespace APA202Api.Models;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public int Stock { get; set; }
    public Category Category { get; set; }
}
