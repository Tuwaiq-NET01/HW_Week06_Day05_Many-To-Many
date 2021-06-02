using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//to use dbcontext file -> need to import
using CodeFirst.Data;
using CodeFirst.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeFirst.Controllers
{
    public class StudentsController : Controller
    {
        //anything private use _ then name

        private readonly AppDbContext _db;//db ineract with database

        //first method we want it to excute is constructor

        public StudentsController(AppDbContext context)//interact with the database
        {
            _db = context;
        }


        ///

        // GET: /<controller>/
        public IActionResult Index()
        {
            var Students = _db.Students.ToList<StudentModel>();



            //Week06_day04 LINQ
            //return the addre
            //var id1 = _db.Students.FirstOrDefault(a => a.Id == 1)?.Eamil;//first linq function question mark means of null -> to not throw exception
            //ViewBag.Id = id1;

            //var id2 = _db.Students.SingleOrDefault(a => a.Id == 6).FirstName;
            //ViewBag.Id = id2;



            //to pass to view:
            ViewData["Students"] = Students;
            return View();

        }

        //Week06Day04
        //to create search button

        public IActionResult Search(string txt)
        {
            var SearchResult = _db.Students.Where(a => a.FirstName.Substring(0, 1) == txt).ToList();

            if (SearchResult.Count()>0)
            {
                ViewData["SearchResult"] = SearchResult;
                
            }
            else
            {
                return Content("RESULT NOT FOUND");
            }
            

            return View();//it means it will pass Index to the view no need to create view
        }


        public IActionResult Details(int id)
        {
            var Student = _db.Students.ToList().Find(s => s.Id == id);

            if(Student == null)//اي مكان يطلع خطا استدعيه من اي مكان
            {
                return Content("STUDENT NOT FOUND");

            }
            else
            {
                ViewData["Student"] = Student;
                
            }

            return View();

        }



    }
}
