using System.Linq;
using CodeFirstApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AppDbContext _db;

        public CustomersController(AppDbContext db)
        {
            _db = db;
        }
        // GET
        public IActionResult Index()
        {
            var customers = _db.Customers.ToList();
            ViewData["customers"] = customers;
            return View();
        }
    }
}