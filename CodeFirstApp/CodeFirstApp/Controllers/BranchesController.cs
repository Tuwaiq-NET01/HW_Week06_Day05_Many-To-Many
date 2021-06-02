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
        private readonly AppDbContext _db; // _ bc private
        public BranchesController(AppDbContext context) // interacting with AppDbContext and fetching data from it
        {
            _db = context;
        }
        public IActionResult Index()
        {

            var searchById = _db.Branches.FirstOrDefault(a => a.Id == 2).Address; // Search by ID and print the address(not id) only prints the first with this id
            var searchById2 = _db.Branches.SingleOrDefault(a => a.Id == 2).Address; // Single Gives an exception if it doesn't exist

            var greaterThanThree = _db.Branches.Where(a => a.Id > 3).ToList();


            ViewData["searchById"] = searchById;
            ViewData["searchById2"] = searchById2;
            ViewData["greaterThanThree"] = greaterThanThree;


            var Branches = _db.Branches.ToList();
            ViewData["Branches"] = Branches;
            return View();
        }
        public IActionResult Search(string txt)
        {
            var aa = _db.Branches.Where(a => a.Address.Contains(txt)).ToList();
            ViewData["Branches"] = aa;
            return View("Index");

        }
    }
}
