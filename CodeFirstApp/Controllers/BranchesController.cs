using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
using CodeFirstApp.Data;

namespace CodeFirstApp.Controllers
{
    public class BranchesController : Controller
    {
        private readonly AppDbContext _db;

        public BranchesController(AppDbContext context)
        {
            _db = context;
        }

        //GET: /controller/
        public IActionResult Index()
        {
            var Branches = _db.Branches.ToList();
            ViewData["Branches"] = Branches;

            // var searchById = _db.Branches.FirstOrDefault(a => a.Id == 2).Address;
            var searchById = _db.Branches.SingleOrDefault(a => a.Id == 2).Address;
            var greaterThanThree = _db.Branches.Where(a => a.Id > 2).ToList();

            ViewData["Branchy"] = searchById;
            ViewData["Greater"] = greaterThanThree;

            return View();
        }
        public IActionResult Search(string txt)
        {
            var aa = _db.Branches.Where(a => a.Address.Contains(txt)).ToList();
            ViewData["search"] = aa;
            return View("Index");
        }
    }
}
