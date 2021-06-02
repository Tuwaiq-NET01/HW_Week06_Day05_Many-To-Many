using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFristApp.Data;

namespace CodeFristApp.Controllers
{
    public class CostomersController : Controller
    {
        private readonly AppDbContext _db;

        public CostomersController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            var searchbyid = _db.Branch.FirstOrDefault(a => a.Id == 2);
            ViewData["searchbyid"] = searchbyid;


            var Costomers = _db.Costomers.ToList();
            ViewData["Costomers"] = Costomers;
            return View();
        }
    }
}
