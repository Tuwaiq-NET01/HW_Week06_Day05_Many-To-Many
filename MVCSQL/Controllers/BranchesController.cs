using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCSQL.Models;
using MVCSQL.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCSQL.Controllers
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
            var searchByID = _db.Branches.FirstOrDefault(branch => branch.Id == 2);
            ViewBag.SearchByID = searchByID;
            var searchByAddress = _db.Branches.Where(branch => branch.Address == "Riyadh").ToList();
            ViewBag.SearchByAddress = searchByAddress;
            var DbBranches = _db.Branches.ToList();
            ViewBag.Branches = DbBranches;
            return View();
        }
        public IActionResult Search(string searchKey)
        {
            var searchResults = _db.Branches.Where(branch => branch.Address == searchKey).ToList();
            ViewBag.SearchResults = searchResults;
            return View("Index");
        }
    }
}
