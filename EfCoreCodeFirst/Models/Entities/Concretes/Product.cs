using EfCoreCodeFirst.Models.Entities.Abstracts;

namespace EfCoreCodeFirst.Models.Entities.Concretes;



public class Product : BaseEntity
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}

