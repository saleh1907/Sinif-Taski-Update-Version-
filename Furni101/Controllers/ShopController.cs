using Furni101.Contexts;
using Furni101.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Furni101.Controllers
{
    public class ShopController : Controller
    {
        private readonly DataContext _context;


        public ShopController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            List<Product> products = _context.Products.ToList();
            return View(products);
        }
    }
}
