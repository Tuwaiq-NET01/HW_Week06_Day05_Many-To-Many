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
            var branches = _db.Branches.ToList();
            ViewData["Branches"] = branches;


            var searchByID = _db.Branches.FirstOrDefault(a => a.ID == 2).Area;

            ViewData["searchByID"] = searchByID;

            

            return View();
        }

        public IActionResult Search(string txt)
        {
            //var branches = _db.Branches.ToList();
            //ViewData["Branches"] = branches;

            var searchByArea = _db.Branches.Where(a => a.Area.Contains(txt)).ToList();

            ViewData["Branches"] = searchByArea;



            return View("Index");
        }
    }
}
