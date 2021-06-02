using System;
using System.Linq;
using CodeFirst.Data;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _db;

        public StudentsController(AppDbContext context)
        {
            _db = context;
        }
        // GET
        public IActionResult Index()
        {
            var students = _db.Students.ToList();
            var studFirstName = _db.Students.FirstOrDefault(a => a.Id == 1).FirstName;
            var studLastName = _db.Students.SingleOrDefault(a => a.Id == 1).LastName;
            var studList = _db.Students.Where(a => a.Id == 3).ToList();
            ViewData["Students"] = students;
            ViewData["studFirstName"] = studFirstName;
            ViewData["studLastName"] = studLastName;
            // ViewData["studList"] = studList;
            return View();
        }
        public IActionResult Search(string txttxt)
        {
            // if (txttxt != null)
            // {
                var searchResult = _db.Students.Where(a => a.FirstName.Contains(txttxt) || a.LastName.Contains(txttxt)).ToList();
                ViewData["Students"] = searchResult;
            // }
            
            return View("Index");
        }
        public IActionResult Detail(int? id)
        {
            // both work
            // var searchResult = _db.Students.SingleOrDefault(stud => stud.Id == id);
            var searchResult = _db.Students.ToList().Find(stud => stud.Id == id);
            if (searchResult == null)
            {
                return View("NotFound");
            }
            ViewData["Student"] = searchResult;

                return View();
        }
    }
}