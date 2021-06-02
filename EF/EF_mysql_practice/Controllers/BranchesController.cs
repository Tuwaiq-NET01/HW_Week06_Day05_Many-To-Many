using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EF_mysql_practice.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF_mysql_practice.Controllers
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
            var d = _db.Branches.FirstOrDefault(x => x.Id == 2).Address;
            ViewData["d"] = d;

            var greatthan3 = _db.Branches.Where(a => a.Id > 0).ToList();
            ViewData["g"] = greatthan3;

            var Branches = _db.Branches.ToList();
            ViewData["Branches"] = Branches;
            return View("Index");
        }
        public IActionResult Search(string txt)
        {
            var aa = _db.Branches.Where(a => a.Address.Contains(txt)).ToList();
            ViewData["aa"] = aa;
            return View("Index");
        }
    }
}
