using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWithMySQL.Data;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectWithMySQL.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _db;
        public StudentsController(AppDbContext context)
        {
            _db = context;
        }
        // GET: /<controller>/
        public IActionResult Index(int id)
        {
            //var Student = _db.Students.FirstOrDefault(s => s.id == 1);
            //ViewData["Student1"] = Student;

            var Students = _db.Students.Where(s => s.id == id).ToList();
            //ViewData["Student1"] = greatThantwo;
            //Console.WriteLine(Student);
            //var Students = _db.Students.ToList();
            ViewData["Students"] = Students;

            return View();
        }
        public IActionResult Details(int? Id)
        {

           var Student= _db.Students.ToList().Find(s=> s.id==Id );
            if (Student == null) return Content(" <h1 >Error 404 page not found </h1> ","text/html");
            ViewData["Student"] = Student;

            return View();
        }


        public IActionResult Search(String txt )
        {
            //return Content(txt);
            var isDigit = Int32.TryParse(txt, out int number);


            // e ? action1 : action2
            var Students = _db.Students.Where(s => isDigit ? s.id == number : s.Name.Contains(txt)  ).ToList();

            ViewData["Students"] = Students;
            return View();
        }
    }
}
