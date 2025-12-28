using Furni101.Contexts;
using Furni101.Models;
using Microsoft.AspNetCore.Mvc;

namespace Furni101.Controllers
{
    public class AboutUs : Controller
    {
        private readonly DataContext _context;

        public AboutUs(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Employee> employees = _context.Employees.ToList();
            return View(employees);
        }
    }
}
