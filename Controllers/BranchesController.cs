using System;
using System.Linq;
using EFIntro.Data;
using Microsoft.AspNetCore.Mvc;

namespace EFIntro.Controllers
{
    public class BranchesController : Controller
    {

        private readonly AppDbContext _context;

        public BranchesController(AppDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index(string searchString)
        {
            // if (!String.IsNullOrEmpty(searchString))
            // {
            //     //var searchById = _context.Branches.FirstOrDefault(b => b.Id == 2);
            //     var searchRes = _context.Branches.Where(b => b.Address.Contains(searchString)).ToList();
            //     ViewData["branches"] = searchRes;
            // }
            // else
            // {
                var branches = _context.Branches.ToList();
                ViewData["branches"] = branches;
            //}

            return View();
        }

        public IActionResult Search(string txt)
        {
            var searchRes = _context.Branches.Where(b => b.Address.Contains(txt)).ToList();
            ViewData["branches"] = searchRes;
            return View("Index");
        }
    }
}