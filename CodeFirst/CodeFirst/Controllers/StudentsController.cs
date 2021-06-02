using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Models;
using CodeFirst.Data;
namespace CodeFirst.Controllers
{
    public class StudentsController : Controller
    {
        // make a constructor to execute first bsefor any action in this Controoller for one reson to interaact with Database 
        public StudentsController(AppDbContext context)
        {
            _db = context;

        }
        private readonly AppDbContext _db; // reading just
        public IActionResult Index()
        {
            //  var Students = _db.Students; //return as a collection or dectionary so?

           var Students = _db.Students.ToList(); //convert to list 

            var stName = _db.Students.FirstOrDefault(a => a.ID == 1).FullName;
            var greatThanOne = _db.Students.Where(a => a.ID > 1).ToList();
            ViewData["greatThanOne"] = greatThanOne;
            ViewBag.fullName = stName;
           ViewData["Students"] = Students;
        
            return View();
        }
        public IActionResult Search(string txt)
        {
            var aa = _db.Students.Where(a => a.LastName.Contains(txt) || a.Email.Contains(txt)).ToList();
            ViewBag.Students = aa;

            return View("Index");
        }

        public IActionResult Details(int ? id)
        {
            var aa = _db.Students.Where(a => a.ID == (id?? 0)).ToList();
            ViewBag.Students = aa;
            return View("Index");

        }
    }
}
