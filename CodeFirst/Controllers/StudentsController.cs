using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Data;
using CodeFirst.Models;
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

            //var Students = _db.Students.FirstOrDefault(s => s.Id == 1);
            var Students = _db.Students.ToList();
            ViewData["Students"] = Students;
            return View();
        }

        public IActionResult Search(string txt)
        {

            var Students = _db.Students.Where(s => s.FirstName.Contains(txt) || s.LastName.Contains(txt)).ToList();
            ViewData["Students"] = Students;
            return View("Index");
        }

        public IActionResult Details(int? id)
        {
            var Student = _db.Students.FirstOrDefault(s => s.Id == id);
            ViewBag.Student = Student;
            return View();
        }

    }
}
