using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstApp.Data;


namespace CodeFirstApp.Controllers
{
    public class BranchsController : Controller
    {//للوصول للsedb
        private readonly AppDbContext _db;
        public BranchsController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
       

            var Branches = _db.Branchs.ToList();
            ViewData["Branches"] = Branches;
          

            return View();
        }
        public IActionResult Search(string txt)
        {
            var aa = _db.Branchs.Where(a => a.Adress.Contains(txt)).ToList();
            ViewBag.Branches = aa;

            return View();
        }
    }
}
