using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudFirst.Data;
using CloudFirst.Models;

namespace CloudFirst.Controllers
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
            var Students = _db.Students.ToList();
            var findMe = _db.Students.FirstOrDefault(a => a.Id == 1)?.LastName;
            var ab = _db.Students.SingleOrDefault(a => a.Id == 3)?.FirstName;
            var greateThantwo = _db.Students.Where(a => a.Id >= 2).ToList();
            ViewData["students"] = Students;
            ViewData["findu"] = findMe;
            ViewData["abu"] = ab;
            ViewData["greateThantwou"] = greateThantwo;
            return View();
        }
        public IActionResult Search(string txt)
        {
            var searchFor = _db.Students.Where(a => a.FirstName.Contains(txt) || a.LastName.Contains(txt)).ToList();
            ViewBag.Students = searchFor;

            return View("Index");
        }
        public IActionResult Details(int? id)
        {
            var s1 =_db.Students.ToList().Find(s => s.Id == id);
            if(s1 == null)
            {
                return View("NotFound");
            }
            ViewData["s1"] = s1;
            return View();

        }
    }
   /* public IActionResult Check(int? id)
    {
        ProductModel product = Product.Find(match: model => model.Id == id);

        if (product == null)
        {
            return Content("No product with that name");
        }
        else
        {
            ViewData["products"] = product;
            return View();
        }
    }*/
}

