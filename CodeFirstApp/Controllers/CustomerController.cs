using CodeFirstApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _db;
        public CustomerController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Cusomers = _db.Customers.ToList();

            return Json(Cusomers);
        }
    }
}
