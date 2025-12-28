using System;
using Furni101.Contexts;
using Furni101.Models;
using Microsoft.AspNetCore.Mvc;

namespace Furni101.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var employees= _context.Employees.ToList();
            return View(employees);
        }


        [HttpGet]
        public IActionResult Create()
        {


            return View();
        }


        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }

            _context.Employees.Add(employee);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));


        }
    }

}
