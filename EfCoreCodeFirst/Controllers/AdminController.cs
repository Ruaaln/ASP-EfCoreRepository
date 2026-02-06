using EfCoreCodeFirst.Models.Entities.Concretes;
using EfCoreCodeFirst.Repositories;
using EfCoreCodeFirst.ViewModel.Categories;
using EfCoreCodeFirst.ViewModel.Products;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreCodeFirst.Controllers;

public class AdminController : Controller
{

    //add _categoryRepo
    private readonly CategoryRepository _categoryRepo;
    private readonly ProductRepository _productRepo;

    public AdminController(
        CategoryRepository categoryRepo,
        ProductRepository productRepo)
    {
        _categoryRepo = categoryRepo;
        _productRepo = productRepo;
    }


    public IActionResult Index()
    {
        var products = _productRepo.GetAll();
        return View(products);
    }

    #region Category
    [HttpGet]
    public IActionResult AddCategory()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddCategory(AddCategoryVM vm)
    {
        if (!ModelState.IsValid)
            return View(vm);

        var category = new Category
        {
            Name = vm.Name
        };

        _categoryRepo.Add(category);
        return RedirectToAction("CategoryList");
    }

    [HttpGet]
    public IActionResult CategoryList()
    {
        var categories = _categoryRepo.GetAll();
        return View(categories);
    }

    [HttpGet]
    public IActionResult EditCategory(int id)
    {
        var category = _categoryRepo.GetById(id);
        if (category == null) return NotFound();

        var vm = new AddCategoryVM
        {
            Name = category.Name
        };

        return View(vm);
    }

    [HttpPost]
    public IActionResult EditCategory(int id, AddCategoryVM vm)
    {
        if (!ModelState.IsValid)
            return View(vm);

        var category = _categoryRepo.GetById(id);
        if (category == null) return NotFound();

        category.Name = vm.Name;

        _categoryRepo.Update(category);
        return RedirectToAction("CategoryList");
    }

    [HttpGet]
    public IActionResult DeleteCategory(int id)
    {
        var category = _categoryRepo.GetById(id);
        if (category == null) return NotFound();

        return View(category);
    }

    [HttpPost]
    public IActionResult DeleteCategoryConfirmed(int id)
    {
        _categoryRepo.Delete(id);
        return RedirectToAction("CategoryList");
    }
    #endregion

    #region Products

    public IActionResult ProductList()
    {
        var products = _productRepo.GetAll();
        return View(products);
    }


    [HttpGet]
    public IActionResult AddProduct()
    {
        ViewBag.Categories = _categoryRepo.GetAll();
        return View();
    }

    [HttpPost]
    public IActionResult AddProduct(AddProductVM vm)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Categories = _categoryRepo.GetAll(); // ← BU SƏTİR VACİBDİR
            return View(vm);
        }

        var product = new Product
        {
            Name = vm.Name,
            Price = vm.Price,
            Description = vm.Description,
            CategoryId = vm.CategoriId!.Value
        };

        _productRepo.Add(product);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult EditProduct(int id)
    {
        var product = _productRepo.GetById(id);
        if (product == null) return NotFound();

        var vm = new AddProductVM
        {
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            CategoriId = product.CategoryId
        };

        ViewBag.Categories = _categoryRepo.GetAll();
        return View(vm);
    }

    [HttpPost]
    public IActionResult EditProduct(int id, AddProductVM vm)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Categories = _categoryRepo.GetAll();
            return View(vm);
        }

        var product = _productRepo.GetById(id);
        if (product == null) return NotFound();

        product.Name = vm.Name;
        product.Price = vm.Price;
        product.Description = vm.Description;
        product.CategoryId = vm.CategoriId!.Value;

        _productRepo.Update(product);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult DeleteProduct(int id)
    {
        var product = _productRepo.GetById(id);
        if (product == null) return NotFound();

        return View(product);
    }

    [HttpPost]
    public IActionResult DeleteProductConfirmed(int id)
    {
        _productRepo.Delete(id);
        return RedirectToAction("Index");
    }



    #endregion


}
