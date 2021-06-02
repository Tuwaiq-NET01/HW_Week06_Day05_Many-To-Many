using CodeFirst.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var STDLOL = _db.Students.FirstOrDefault(a => a.Id == 1).LastName;
            var students = _db.Students.ToList();
            ViewData["students"] = students;
            ViewData["LastName"] = STDLOL;
            return View();
        }
        public IActionResult Search(string txt)
        {
            //return Content(txt);
            var aa = _db.Students.Where(a => a.LastName.Contains(txt)).ToList();
            ViewData["students"] = aa;
            return View("Index");
        }
        public IActionResult Details(int? id)
        {
            //return Content(txt);
            var i = _db.Students.FirstOrDefault(s => s.Id == id);
            ViewData["Detail"] = i;
            return i == null ? View("notFound") : View();
        }
    }
}
