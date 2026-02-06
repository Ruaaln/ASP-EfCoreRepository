using EfCoreCodeFirst.Models.Entities.Abstracts;

namespace EfCoreCodeFirst.Models.Entities.Concretes;

public class User : BaseEntity
{
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public int Age { get; set; }
    public string PasswordHash { get; set; } = null!;
}
