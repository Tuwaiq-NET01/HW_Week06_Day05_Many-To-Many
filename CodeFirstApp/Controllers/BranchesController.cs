using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult Index()
        {
            var searchbyId = _db.Branchs.SingleOrDefault(a => a.id == 2).Address;

            var greatthanthree = _db.Branchs.Where(a => a.id > 3).ToList();

            ViewData["searchbyId"] = searchbyId;
            ViewData["greatthanthree"] = greatthanthree;

            var Branchs = _db.Branchs.ToList();
            ViewData["Branchs"] = Branchs;
            return View();
        }


        public IActionResult Search(string txt)
        {
            var aa = _db.Branchs.Where(a => a.Address.Contains(txt)).ToList();
            ViewData["BranchsS"] = aa;

            var searchbyId = _db.Branchs.SingleOrDefault(a => a.id == 2).Address;

            var greatthanthree = _db.Branchs.Where(a => a.id > 3).ToList();

            ViewData["searchbyId"] = searchbyId;
            ViewData["greatthanthree"] = greatthanthree;

            var Branchs = _db.Branchs.ToList();
            ViewData["Branchs"] = Branchs;

            return View("Index");

        }
    }
}
