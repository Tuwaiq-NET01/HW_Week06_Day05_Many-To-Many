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

            var searchbyId = _db.Branches.FirstOrDefault(a => a.Id == 2).Address;
            var searchbyId2 = _db.Branches.SingleOrDefault(a => a.Id == 1).Address;

            var greatthanthree = _db.Branches.Where(a => a.Id > 3).ToList();


            var Branches = _db.Branches.ToList();


             ViewData["Branches"] = Branches;
             ViewBag.address = searchbyId;
             ViewBag.address = searchbyId2;
             ViewData["greaterthanthree"] = greatthanthree;

            return View();
        }


        public IActionResult Search(string txt)
        {
            var aa = _db.Branches.Where(a => a.Address.Contains(txt)).ToList();
            ViewBag.Branches = aa;

            return View("Index");
        }
    }
}
