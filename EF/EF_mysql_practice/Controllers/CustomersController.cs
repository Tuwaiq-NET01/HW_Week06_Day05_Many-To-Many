using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EF_mysql_practice.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF_mysql_practice.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AppDbContext _db;
        public CustomersController(AppDbContext context)
        {
            _db = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var Customers = _db.Customers.ToList();
            ViewData["customers"] = Customers;
            return View();
        }
    }
}
