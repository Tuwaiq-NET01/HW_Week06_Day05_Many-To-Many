using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_ef.Models;
using System.ComponentModel.DataAnnotations;
using mvc_ef.Data;


namespace mvc_ef.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext context)
        {
            _db = context;
        }


        public IActionResult Index()
        {

            try
            {
                var teacher_name = _db.Teachers.ToList();

                ViewData["teacher_name"] = teacher_name;
                return View();
            }
            catch (Exception)
            {
               return Content("WHYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY");
            }
        }

        public IActionResult Details( int id )
        {
            
            var query = 
            from teacher in _db.Teachers
            where teacher.Id == id
            select teacher;
            ViewData["teacher_details"] = query;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
