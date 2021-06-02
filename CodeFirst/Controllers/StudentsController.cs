using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Data;
using System.Diagnostics;
using CodeFirst.Models;

namespace CodeFirst.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDBContext _db;

        public StudentsController(AppDBContext context) 
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var Students = _db.Students.ToList();
            ViewData["Students"] = Students;
            Debug.WriteLine("Inside student index");
            return View();
        }

        public IActionResult Id(int id)
        {
            var name = _db.Students.FirstOrDefault(a => a.Id == id).FirstName;
            ViewData["First Name"] = name;

            var greaterThanTwo = _db.Students.Where(a => a.Id > 2).ToList();
            ViewData["Id List"] = greaterThanTwo;
            return View();
        }

        public IActionResult Search(string txt)
        {
            var a = _db.Students.Where(a => a.FirstName.Contains(txt) || a.LastName.Contains(txt)).ToList();
            Debug.WriteLine("search result     "+a);
            ViewData["search"] = a;
            return View("Search");
        }

        public IActionResult Details(int Id)
        {
            var a = _db.Students.ToList().Find(a => a.Id == Id);
            ViewData["details"] = a;
            return View();
        }
    }
}
