using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolMVCef.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolMVCef.Controllers
{
    public class TeachersController : Controller
    {
        private readonly AppDbContext _db;

        public TeachersController(AppDbContext context)
        {
            _db = context;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var DbTeachers = _db.Teachers.ToList();
            ViewBag.Teachers = DbTeachers;
            return View();
        }
    }
}
