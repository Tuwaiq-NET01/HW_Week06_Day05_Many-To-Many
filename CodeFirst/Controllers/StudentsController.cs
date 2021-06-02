using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Data;

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
            var std1 = _db.Students.FirstOrDefault(a => a.Id == 3).FirstName;
            var std2 = _db.Students.SingleOrDefault(a => a.Id == 2).FirstName; //supposed to give you an error if not found.

            var greaterThanTwo = _db.Students.Where(a => a.Id > 2).ToList();

            var Students = _db.Students.ToList();


            ViewData["std1"] = std1;
            ViewData["std2"] = std2;
            ViewData["greaterThanTwo"] = greaterThanTwo;
            ViewData["Students"] = Students;
            return View();
        }


        public IActionResult Search(string txt)
        {

            var target = txt;
            var searchRes = _db.Students.Where(a => a.FirstName.Contains(target) || a.LastName.Contains(target)).ToList();
            ViewData["target"] = target;
            ViewData["searchRes"] = searchRes;
            return View();

        }

        //GET students/details/id?
        public IActionResult Details(int id)
        {
            var stundent = _db.Students.ToList().Find(a => a.Id == id);

            if(stundent == null)
            {
                return View("fof");
            }
            ViewData["stundent"] = stundent;
            return View();
        }


    }
}
