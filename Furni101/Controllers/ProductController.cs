using Furni101.Contexts;
using Furni101.Models;
using Furni101.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Furni101.Controllers;

public class ProductController : Controller
{
    private readonly DataContext _context;

    public ProductController(DataContext context)
    {
        _context = context;
    }

  
    public IActionResult Index()
    {
        var products = _context.Products.ToList();
        return View(products);
    }

    public IActionResult Create()
    {
        return View();
    }

 
    [HttpPost]
    public IActionResult Create(ProductCreateVM vm)
    {
        if (!ModelState.IsValid)
            return View(vm);

        Product product = new Product
        {
            Name = vm.Name,
            Price = vm.Price,
            ImageName = vm.ImageName,
            ImageUrl = vm.ImageUrl
        };

        _context.Products.Add(product);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }


    public IActionResult Update(int id)
    {
        var product = _context.Products.FirstOrDefault(x => x.Id == id);
        if (product is null)
            return NotFound();

        ProductUpdateVM vm = new ProductUpdateVM
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            ImageName = product.ImageName,
            ImageUrl = product.ImageUrl
        };

        return View(vm);
    }

    [HttpPost]
    public IActionResult Update(ProductUpdateVM vm)
    {
        if (!ModelState.IsValid)
            return View(vm);

        var product = _context.Products.FirstOrDefault(x => x.Id == vm.Id);
        if (product is null)
            return NotFound();

        product.Name = vm.Name;
        product.Price = vm.Price;
        product.ImageName = vm.ImageName;
        product.ImageUrl = vm.ImageUrl;

        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var product = _context.Products.FirstOrDefault(x => x.Id == id);
        if (product is null)
            return NotFound();

        _context.Products.Remove(product);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}
