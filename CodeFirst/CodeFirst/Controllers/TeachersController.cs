using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Data;
namespace CodeFirst.Controllers
{
    public class TeachersController : Controller
    {
        //interact with DB .. feach data
        private readonly AppDbContext _db;

        public TeachersController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Teachers = _db.Teachers.ToList();
            ViewData["Teachers"] = Teachers;
            return View();
        }
    }
}
