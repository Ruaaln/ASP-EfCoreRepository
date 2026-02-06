using System.ComponentModel.DataAnnotations;

namespace EfCoreCodeFirst.Validations;

public class LoginValidation
{
    [Required(ErrorMessage = "Username boş ola bilməz")]
    [MinLength(3, ErrorMessage = "Username minimum 3 simvol olmalıdır")]
    [MaxLength(20, ErrorMessage = "Username maksimum 20 simvol ola bilər")]
    [RegularExpression(@"^[a-zA-Z0-9._-]+$", ErrorMessage = "Username yalnız hərf, rəqəm və . _ - qəbul edir")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Password boş ola bilməz")]
    [MinLength(8, ErrorMessage = "Password minimum 8 simvol olmalıdır")]
    [MaxLength(32, ErrorMessage = "Password maksimum 32 simvol ola bilər")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
}
