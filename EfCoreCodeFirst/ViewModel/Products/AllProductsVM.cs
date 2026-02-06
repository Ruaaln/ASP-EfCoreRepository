using EfCoreCodeFirst.Models.Entities.Concretes;

namespace EfCoreCodeFirst.ViewModel.Products;

public class AllProductVM
{
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public string? Description { get; set; }

    public int CategoryId { get; set; }
    public List<Category> Categories { get; set; } = new();
}

