using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeFirst.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeFirst.Controllers
{
    public class BranchesController : Controller
    {
        private readonly AppDbContext _db;

        public BranchesController(AppDbContext context)
        {
            _db = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var Branches = _db.Branches.ToList();
            //var searchResult = _db.Branches.FirstOrDefault(a => a.Id == id);
            //var searchResult = _db.Branches.SingleOrDefault(a => a.Address == search);
            //var searchResult = _db.Branches.FirstOrDefault(a => a.Id == id).Address;

            //if (searchResult == null)
            //{
            //    return new EmptyResult();
            //}
            //ViewBag.searchResult = searchResult;
            ViewBag.Branches = Branches;
            return View();
        }

        public IActionResult Search(string txt)
        {
            var aa = _db.Branches.Where(a => a.Address.Contains(txt) || a.Area.Contains(txt)|| a.Name.Contains(txt)).ToList();
            ViewBag.Branches = aa;
            return View("Index");
        }
    }
}
