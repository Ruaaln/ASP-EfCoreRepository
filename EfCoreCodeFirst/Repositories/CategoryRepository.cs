using EfCoreCodeFirst.Data;
using EfCoreCodeFirst.Models.Entities.Concretes;

namespace EfCoreCodeFirst.Repositories;

public class CategoryRepository
{
    public readonly DataContext _context;

    public CategoryRepository(DataContext context)
    {
        _context = context;
    }

    public void Add(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
    }
    
    public Category? GetById(int id)
    {
        return _context.Categories.FirstOrDefault(x => x.Id == id);
    }
    public List<Category> GetAll()
    {
        return _context.Categories.ToList();
    }


    public void Update(Category category)
    {
        var existingCategory = GetById(category.Id);
        if (existingCategory == null) return;
        existingCategory.Name = category.Name;
        _context.SaveChanges();
    }
    public void Delete(int id)
    {
        var category = _context.Categories.FirstOrDefault(x => x.Id == id);
        if (category == null) return;
        _context.Categories.Remove(category);
        _context.SaveChanges();
    }


}

