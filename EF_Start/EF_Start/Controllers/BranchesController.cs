using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Start.Data;
using EF_Start.Models;

namespace EF_Start.Controllers
{
    public class BranchesController : Controller
    {
        private readonly AppDbContext _db;
        public BranchesController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Branches = _db.Branchs.ToList();
            /* var searchById = _db.Branchs.FirstOrDefault(a => a.Id == 2);*/
            var searchAdreesById = _db.Branchs.FirstOrDefault(a => a.Id == 2).Address;
            /*var searchAdreesById = _db.Branchs.SingleOrDefault(a => a.Id == 2).Address;*/ // for error in Id in database
            var searchGreatThanThree = _db.Branchs.Where(a => a.Id > 2).ToList();
            ViewData["Branches"] = Branches;
            /*ViewData["searchById"] = searchById;*/
            ViewData["searchAdreesById"] = searchAdreesById;
            ViewData["searchGreatThanThree"] = searchGreatThanThree;
            return View();


        }

        public IActionResult Search(string txt)
        {
            var aa = _db.Branchs.Where(a => a.Address.Contains(txt)).ToList();
            /*ViewData["aa"] = aa;*/
            /*ViewBag.Branchs = aa;*/
            ViewData["Branches"] = aa;
            return View("Index");
        }
    }
}
