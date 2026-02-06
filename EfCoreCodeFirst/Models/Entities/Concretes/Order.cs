using EfCoreCodeFirst.Models.Entities.Abstracts;

namespace EfCoreCodeFirst.Models.Entities.Concretes;

public class Order : BaseEntity
{
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public int UserID { get; set; }
    public User User { get; set; } = null!;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
