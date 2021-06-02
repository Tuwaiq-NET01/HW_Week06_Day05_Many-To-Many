using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Data
{
    public class BranchsController : Controller
    {
        private readonly AppDbContext _db;
        public BranchsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Branches = _db.Branchs.ToList();


            return Json(Branches);
        }
        public IActionResult firstBranch()
        {
            var Branches = _db.Branchs.SingleOrDefault(a => a.Id == 1).address;

            var b = _db.Branchs.Where(a => a.Id > 2);


            return Json(b);
        }
        public IActionResult Search(string txt)
        {
            var aa = _db.Branchs.Where(a => a.address.Contains(txt)).ToList();

            return Json(aa);
        }


    }
}
