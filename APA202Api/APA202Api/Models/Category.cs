using APA202Api.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace APA202Api.Models;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }
}
