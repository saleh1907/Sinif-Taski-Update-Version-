using Furni101.Contexts;
using Furni101.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Furni101.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController(DataContext _context) : Controller
    {

        public IActionResult Index()
        {
            var blogs = _context.bLogs.ToList();
            return View(blogs);
        }


        [HttpGet]
        public IActionResult Create()
        {


            return View();
        }


        [HttpPost]
        public IActionResult Create(BLog blog)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }

            _context.bLogs.Add(blog);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));


        }
    }
}
