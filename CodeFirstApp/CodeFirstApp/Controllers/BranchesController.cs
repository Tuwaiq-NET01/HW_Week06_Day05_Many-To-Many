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
           var searchById = _db.Branches.FirstOrDefault(a => a.Id == 2);
           var searchById2 = _db.Branches.FirstOrDefault(a => a.Id == 2).Address;
           var searchById3 = _db.Branches.SingleOrDefault(a => a.Id == 2).Address;//throw an excepations
            var greaterthanthree = _db.Branches.Where(a => a.Id > 3).ToList();

            ViewData["ID"] = searchById;
            ViewBag.Address = searchById2;
            ViewBag.Address2 = searchById3;
            ViewBag.greaterthanthree = greaterthanthree;

            var Branches = _db.Branches.ToList();
           
            ViewData["Branches"] = Branches;
            return View();
        }
        public IActionResult Search(string txt)
        {
            var ad = _db.Branches.Where(a => a.Address.Contains(txt)).ToList();
            ViewBag.Branches = ad;
            return View("Index");
        }
    }
}
