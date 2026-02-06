using EfCoreCodeFirst.Models.Entities.Abstracts;

namespace EfCoreCodeFirst.Models.Entities.Concretes;

public class Category : BaseEntity
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }

    public ICollection<Product>? Products { get; set; }
}
