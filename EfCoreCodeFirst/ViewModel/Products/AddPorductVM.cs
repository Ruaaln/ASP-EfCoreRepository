using EfCoreCodeFirst.Validations;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreCodeFirst.ViewModel.Products;


[ModelMetadataType(typeof(ProductValidetion))]
public class AddProductVM
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public int? CategoriId { get; set; }

}
