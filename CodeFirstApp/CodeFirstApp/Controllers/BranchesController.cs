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
        
        public BranchesController (AppDbContext context)// connect with this app the first time join in request 
            //رايح يجيب كلاس الاب دي بي كونتكس 
        {
            _db = context;
        }
        public IActionResult Index() //we need to access
        {
            var greatthanTwo = _db.Branches.Where(a => a.Id > 2).ToList();

            var searchById = _db.Branches.SingleOrDefault(a => a.Id == 2).Address; //search first element 

            var Branches = _db.Branches.ToList(); // convert to list 


            ViewBag.Address = searchById;

            ViewData["greatthanTwo"] = greatthanTwo;

            ViewData["Branches"] = Branches;
            return View();

            
        }
        public IActionResult Search(string txt)
        {
            var aa = _db.Branches.Where(a => a.Address.Contains(txt)).ToList();
            ViewBag.Branches = aa;


            return View("Index");
        }
    }
}
