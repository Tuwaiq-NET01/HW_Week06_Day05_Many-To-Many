using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstApp.Data;


namespace CodeFirstApp.Controllers
{

    public class CustomersController : Controller
    {
        private readonly AppDbContext _db;
public CustomersController(AppDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            var Custmers = _db.Customers.ToList();
            ViewData["Custmers"] = Custmers;
            return View();
        }
    }
}
