using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CodeFirst.Data;
namespace CodeFirst.Controllers
{
    public class StudentsController : Controller
    {
        
        private readonly AppDbContext _db;

        public StudentsController(AppDbContext ctx)
        {
            _db = ctx;
        }
        // GET
        public IActionResult Index()
        {
            //var Students = _db.Students.ToList();
            var Students = _db.Students.ToList();
            ViewData["Students"] = Students;

            // var student = _db.Students.FirstOrDefault(a => a.Id == 4)?.FirstName;
             var student = _db.Students.SingleOrDefault(a => a.Id == 4)?.FirstName;
            ViewBag.Student = student;
            return View();
        }
        public IActionResult Search(string SearchForName)
        {
            //var Students = _db.Students.ToList();
            int id = 0;
            var Students = _db.Students.Where(s => s.FirstName.Contains(SearchForName) 
                                                   || s.LastName.Contains(SearchForName)
                                                   || (int.TryParse(SearchForName , out id)&& s.Id == id)
                ).ToList();
            ViewData["Students"] = Students;

            
            return View("Index");
        } 
        public IActionResult Details(int? id)
        {
            //var Students = _db.Students.ToList();
          
            var Students = _db.Students.Where(s =>s.Id == (id??0) ).ToList();
            ViewData["Students"] = Students;

            
            return View("Index");
        }
    }
}