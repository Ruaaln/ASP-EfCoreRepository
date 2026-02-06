using System.ComponentModel.DataAnnotations;

namespace EfCoreCodeFirst.ViewModel.Categories;

public class AddCategoryVM
{
    [Required(ErrorMessage = "Category name is required")]
    [MinLength(2, ErrorMessage = "Category name must be at least 2 characters")]
    [MaxLength(40, ErrorMessage = "Category name cannot exceed 40 characters")]
    public string Name { get; set; } = null!;
}
