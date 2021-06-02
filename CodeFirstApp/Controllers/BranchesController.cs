using CodeFirstApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Controllers
{
    public class BranchesController : Controller
    {
        private readonly AppDbContext _db;

        public BranchesController (AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var searchByID = _db.Branches.FirstOrDefault(branch => branch.Id == 2);
            ViewBag.SearchByID = searchByID;

            var searchByAddress = _db.Branches.Where(branch => branch.Address == "Riyadh").ToList();
            ViewBag.SearchByAddress = searchByAddress;

            var DbBranches = _db.Branches.ToList();
            ViewBag.Branches = DbBranches;
            
            return View();
        }

        public IActionResult Search(string txt)
        {
            var searchResults = _db.Branches.Where(branch => branch.Address.Contains(txt)).ToList();
            ViewBag.Branches = searchResults;
            return View("Index");
        }
    }
}
