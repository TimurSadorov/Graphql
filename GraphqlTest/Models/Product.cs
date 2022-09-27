using System.ComponentModel.DataAnnotations;
using Common.Models;

namespace GraphqlTest.Models;

public class Product: BaseEntity<int>
{
    [Required]
    public string Name { get; set; } = null!;
    
    [Required]
    public decimal Price { get; set; }
    
    public string? Description { get; set; }
    
    public List<Order> Orders { get; set; } = null!;
}