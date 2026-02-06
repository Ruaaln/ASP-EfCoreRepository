using EfCoreCodeFirst.Data;
using EfCoreCodeFirst.Models.Entities.Concretes;

namespace EfCoreCodeFirst.Repositories;

public class UserRepository
{
    private readonly DataContext _context;

    public UserRepository(DataContext context)
    {
        _context = context;
    }

    public void Add(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public List<User> GetAll()
    {
        return _context.Users.ToList();
    }
}