using CodeFirstApp1.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp1.Controllers
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
            /*var DbBranches = _db.Branches.ToList();
            ViewBag.Branches = DbBranches;

            var searchbyId = _db.Branches.FirstOrDefault(a => a.Id == 2).Address;
            
            var greaterthan2 = _db.Branches.Where(a => a.Id > 2).ToList();
            
            ViewBag.Address = searchbyId;
            ViewBag.Branches = greaterthan2;*/


            return View();
        }
        
        public IActionResult Details()
        {
            return View();
        }

        /*public IActionResult Search (string text)
        {
            var Search = _db.Branches.Where(a => a.Address.Contains(text)).ToList();
            ViewBag.Branches = Search;
            return View("Index");
        }*/
    }
}
