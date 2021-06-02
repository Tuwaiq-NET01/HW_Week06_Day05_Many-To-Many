using System.Linq;
using CodeFirstApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AppDbContext _context;

        public CustomersController(AppDbContext context)
        {
            this._context = context;
        }
        
        // GET
        public IActionResult Index()
        {
            var branches = this._context.Customers.ToList();
            ViewData["Branches"] = branches;
            
            return View();
        }
    }
}