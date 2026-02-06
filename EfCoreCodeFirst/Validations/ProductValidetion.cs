using System.ComponentModel.DataAnnotations;

namespace EfCoreCodeFirst.Validations;

public class ProductValidetion
{
    [MinLength(3, ErrorMessage = "Product adi 3 simvolden az ola bilmez.")]
    [Required(ErrorMessage = "Product adi daxil edilmeliidir.")]
    public string Name { get; set; }

    [MaxLength(500, ErrorMessage = "Description 500 simvoldan cox ola bilmez.")]
    public string? Description { get; set; }
  
    [Range(0.01, double.MaxValue, ErrorMessage = "Qiymet 0-dan boyuk olmalidir.")]
    [Required(ErrorMessage = "Qiymet daxil edilmeliidir.")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Product category secilmelidir.")]
    public int? CategoriId { get; set; }

}