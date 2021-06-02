using System.Linq;
using EFIntro.Data;
using Microsoft.AspNetCore.Mvc;

namespace EFIntro.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AppDbContext _context;

        public CustomersController(AppDbContext context)
        {
            _context = context;
        }


        // GET
        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();
            ViewData["customers"] = customers;
            return View();
        }
    }
}