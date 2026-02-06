using System.ComponentModel.DataAnnotations;

namespace EfCoreCodeFirst.Validations;

public class RegistorValidations
{
    [Required(ErrorMessage = "Username is required")]
    [MinLength(3, ErrorMessage = "Username must be at least 3 characters long")]
    [MaxLength(20, ErrorMessage = "Username cannot exceed 20 characters")]
    [RegularExpression(@"^[a-zA-Z0-9._-]+$",
    ErrorMessage = "Username may contain only letters, numbers, and the characters . _ -")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Email address is required")]
    [EmailAddress(ErrorMessage = "Invalid email address format")]
    [MaxLength(60, ErrorMessage = "Email address cannot exceed 60 characters")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Age is required")]
    [Range(18, 65, ErrorMessage = "Age must be between 18 and 65")]
    public int? Age { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
    [MaxLength(32, ErrorMessage = "Password cannot exceed 32 characters")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$",
        ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, and one number")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Password confirmation is required")]
    [Compare(nameof(Password), ErrorMessage = "Password and confirmation do not match")]
    [DataType(DataType.Password)]
    public string? ConfirmPassword { get; set; }

}
