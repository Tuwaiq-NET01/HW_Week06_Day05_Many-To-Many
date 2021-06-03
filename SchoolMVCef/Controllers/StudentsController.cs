using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolMVCef.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolMVCef.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _db;

        public StudentsController(AppDbContext context)
        {
            _db = context;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var DbStudents = _db.Students.ToList();
            ViewBag.Students = DbStudents;
            return View();
        }
    }
}