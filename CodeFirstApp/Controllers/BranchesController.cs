using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CodeFirstApp.Data;

namespace CodeFirstApp.Controllers
{
    public class BranchesController : Controller
    {
        private readonly AppDbContext _db;

        public BranchesController(AppDbContext context)
        {
            this._db = context;
        }

        // GET
        public IActionResult Index()
        {
            // var Branches = _db.Branches.ToList();
            /*
            @ViewData["Branches"] = _db.Branches.Where(b => b.Id >= 2).ToList();

            @ViewData["Branch2"] = _db.Branches.SingleOrDefault(b => b.Address == "Riyadh");

            @ViewData["BranchRiyadh"] = _db.Branches.FirstOrDefault(b => b.Address == "Riyadh");
            */
            

            return View();
        }

        public IActionResult Search(string txt)
        {
            /*
            var searchRes = _db.Branches.Where(b => b.Address.Contains(txt)).ToList();
            @ViewData["Result"] = searchRes;
            return View("Index");
        */
            return View("Index");

        }
    }
}