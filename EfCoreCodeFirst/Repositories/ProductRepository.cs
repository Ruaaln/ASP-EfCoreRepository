using EfCoreCodeFirst.Data;
using EfCoreCodeFirst.Models.Entities.Concretes;

namespace EfCoreCodeFirst.Repositories;


public class ProductRepository
{
    private readonly DataContext _context;

    public ProductRepository(DataContext context)
    {
        _context = context;
    }

    public void Add(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public List<Product> GetAll()
    {
        return _context.Products.ToList();
    }

    public Product? GetById(int id)
    {
        return _context.Products.FirstOrDefault(x => x.Id == id);
    }

    public void Delete(int id)
    {
        var product = _context.Products.Find(id);
        if (product == null) return;

        _context.Products.Remove(product);
        _context.SaveChanges();
    }


    public void Update(Product product)
    {
        var existingProduct = GetById(product.Id);
        if (existingProduct == null) return;
        existingProduct.Name = product.Name;
        existingProduct.Price = product.Price;
        existingProduct.CategoryId = product.CategoryId;
        _context.SaveChanges();
    }
}