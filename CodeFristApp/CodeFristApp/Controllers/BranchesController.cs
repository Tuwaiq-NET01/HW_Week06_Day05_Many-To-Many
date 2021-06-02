using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFristApp.Data;


namespace CodeFristApp.Controllers
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

            var searchbyid = _db.Branch.FirstOrDefault(a => a.Addres == "Riyadh").Name;
            ViewData["Searchbyid"] = searchbyid;

            var greatthanthree = _db.Branch.Where(a => a.Id < 3).ToList();
            ViewData["Greatthanthree"] = greatthanthree;


            var Branches = _db.Branch.ToList();
            ViewData["Branches"] = Branches;
            return View();
        }

        public IActionResult Search(string txt)
        {
            var bb = _db.Branch.Where(a => a.Addres.Contains(txt)).ToList();
            ViewData["BB"] = bb;

            return View("Index");
        }
    }
}
