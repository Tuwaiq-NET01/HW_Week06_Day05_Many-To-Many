using CodeFirstApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AppDbContext _db;

        public CustomersController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var customers = _db.Customers.ToList();
            ViewData["Customers"] = customers;

            var FilterByID = _db.Customers.Where(a => a.ID > 2).ToList();

            ViewData["FilterByID"] = FilterByID;

            return View();
        }
    }
}
