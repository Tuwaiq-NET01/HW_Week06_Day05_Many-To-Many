using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Data;

namespace CodeFirst.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _db;
        
        public StudentsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Students = _db.Students.ToList();
           ViewData["Students"] = Students;
           // var Fname = _db.Students.FirstOrDefault(a => a.Id == 1).FirstName;
          //  ViewData["Students1"] = Fname;

          //  var grearThantwo = _db.Students.Where(a => a.Id > 1).ToList();
          //  ViewData["Students"] = grearThantwo;
            return View();
        }
        public IActionResult Search(string txt)
        {
            var aa = _db.Students.Where(a => a.FirstName.Contains(txt)).ToList();
            ViewData["Students"] = aa;
            return View("Index");
        }

        public IActionResult Deatails(int? id)
        {
             var student = _db.Students.ToList().Find(a => a.Id == id);
                ViewData["Students1"] = student;
            
            return View();
        }
    }
}
