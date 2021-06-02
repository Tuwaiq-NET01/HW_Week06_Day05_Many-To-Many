using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Data;
namespace CodeFirst.Controllers
{
    [Route("[controller]/[action]/")]
    public class StudentsController : Controller
    {
        //interact with DB .. feach data
        private readonly AppDbContext _db;

        public StudentsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            //var fname = _db.Students.FirstOrDefault(fname => fname.id == 2).firstName;
            var fname = _db.Students.SingleOrDefault(fname => fname.id == 3).firstName;

            var greaterThanTwo = _db.Students.Where(ID => ID.id > 2).ToList();

            ViewData["greaterThanTwo"] = greaterThanTwo;

            ViewBag.firstName = fname;



            var Students = _db.Students.ToList();
            ViewData["Students"] = Students;
            return View();
        }
        public IActionResult Search(string txt)
        {
            var aa = _db.Students.Where(ID => ID.firstName.Contains(txt) || ID.lastName.Contains(txt)).ToList();
            ViewBag.Students = aa;
            return View("Index");
        }

        [Route("{Searchid:int?}")]
        public IActionResult Details(int? Searchid)
        {
            var studentSearch = _db.Students.ToList().Find(s => s.id == Searchid);
            ViewData["Students"] = studentSearch;

            if (studentSearch == null)
            {
                return View("Search");
            }
           
            return View();
        }
    }
}
