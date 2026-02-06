using EfCoreCodeFirst.Data;
using EfCoreCodeFirst.Models.Entities.Concretes;

namespace EfCoreCodeFirst.Repositories;

public class OrderRepositories
{
    public readonly DataContext _context;
    

    public OrderRepositories(DataContext context)
    {
        _context = context;
    }

    public void Add(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
    }

    public List<Order> GetAllOrderById(int userId)
    {
        return _context.Orders.Where(x => x.Id == userId).ToList();
    }


    public void DeleteById(int id)  
    {
        var order = _context.Orders.FirstOrDefault(x => x.Id == id);
        if (order == null) return;
        _context.Orders.Remove(order);
        _context.SaveChanges();
    }
}