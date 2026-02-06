using EfCoreCodeFirst.Models.Entities.Abstracts;

namespace EfCoreCodeFirst.Models.Entities.Concretes;

public class Favorite : BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
}
    