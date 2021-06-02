using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CodeFirstApp.Data;

namespace CodeFirstApp.Controllers
{
    public class BranchController : Controller
    {
        private readonly AppDbContext _db;

        public BranchController(AppDbContext db)
        {
            _db = db;
        }

            // GET
        public IActionResult Index()
        {
            var Branches = _db.Branches.ToList();
            var searchId = _db.Branches.SingleOrDefault(a => a.Id == 2).Address;
            var greaterthanthree = _db.Branches.Where(a => a.Id > 3).ToList();
            ViewData["ids"] = greaterthanthree;
            ViewData["branches"] = Branches;
            return View();
        }

        public IActionResult Search(string text)
        {
            var aa = _db.Branches.Where(branch => branch.Name.Contains(text)).ToList();
            ViewData["branches"] = aa;
            return View("Index");
        }
    }
}