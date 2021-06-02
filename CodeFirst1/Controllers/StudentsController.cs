using CodeFirst1.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst1.Controllers
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
            var students = _db.Students.ToList();
            ViewData["students"] = students;
            return View();
        }
        public IActionResult Search(string txt)

        {
            var aa = _db.Students.Where(a => a.FirstName.Contains(txt)).ToList();
            ViewBag.Students = aa;
            return View("Index");

        }
    }
}
