using Furni101.Contexts;
using Furni101.Models;
using Microsoft.AspNetCore.Mvc;

namespace Furni101.Controllers
{
    public class BlogController : Controller
    {
        private readonly DataContext _context;

        public BlogController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<BLog> blogs = _context.bLogs.ToList();

            return View(blogs);
        }
    }
}
