using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeFirstApp.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeFirstApp.Controllers
{
    public class BranchesController : Controller
    {
        private readonly AppDbContext _db;

        public BranchesController(AppDbContext context)
        {
            _db = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var Branches = _db.Branches.ToList();
            ViewData["Branches"] = Branches;
            return View();
        }

        //public IActionResult Search(string txt)
        //{
        //    var aa = _db.Branches.Where(a => a.Adress.Contains(txt)).ToList();
        //    ViewData["aa"] = aa;
        //    return View("Index");
        //}
    }
}
