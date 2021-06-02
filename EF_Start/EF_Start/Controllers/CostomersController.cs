using EF_Start.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Start.Controllers
{
    public class CostomersController : Controller
    {
        private readonly AppDbContext _db;
        public CostomersController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Costomers = _db.Customers.ToList();
            ViewData["Costomers"] = Costomers;
            
            return View();
        }
    }
}
