using System.ComponentModel.DataAnnotations;
using Common.Models;

namespace GraphqlTest.Models;

public class Order : BaseEntity<int>
{
    public string? Description { get; set; }
    
    [Required] 
    public DateTime OrderDate { get; set; }
    
    public DateTime? DeliveryDate { get; set; }
    
    [Required]
    public string Address { get; set; } = null!;

    public List<Product>? Products { get; set; }
}