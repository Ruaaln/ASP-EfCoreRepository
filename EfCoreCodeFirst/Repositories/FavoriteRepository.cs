using EfCoreCodeFirst.Data;
using EfCoreCodeFirst.Models.Entities.Concretes;

namespace EfCoreCodeFirst.Repositories;

public class FavoriteRepository
{

    public readonly DataContext _context;

    public FavoriteRepository(DataContext context)
    {
        _context = context;
    }

    public void Add(Favorite favorite)
    {
        _context.Favorites.Add(favorite);
        _context.SaveChanges();
    }


    public List<Favorite> GetAllByUserId(int userId)
    {
        return _context.Favorites.Where(x => x.UserId == userId).ToList();
    }

    public void DeletById(int id)
    {
        var favorite = _context.Favorites.FirstOrDefault(x => x.Id == id);
        if (favorite == null) return;
        _context.Favorites.Remove(favorite);
        _context.SaveChanges();
    }
}
