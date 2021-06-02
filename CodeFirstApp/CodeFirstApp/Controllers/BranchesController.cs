using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CodeFirstApp.Data;


namespace CodeFirstApp.Controllers
{
    public class BranchesController : Controller
    {
        private readonly AppDbContext _db;

        public BranchesController(AppDbContext context)
        {
            _db = context;
        }

        // GET
        public IActionResult Index()
        {
            /*var Branches = _db.Branches.ToList();
            var searchById = _db.Branches.SingleOrDefault(a => a.id == 2).Address;
            var greaterThanTheree = _db.Branches.Where(a => a.id > 3).ToList();
            ViewData["branchesBiggerThanThree"] = greaterThanTheree;
            ViewData["Specific Id"] = searchById;
            ViewData["branches"] = Branches;*/
            
            return View();
        }


        //Get 
        public IActionResult Search(string txt)
        {
            var aa = _db.Branches.Where(a => a.Name.Contains(txt)).ToList();
            ViewData["SearchResults"] = aa;
            return View("Index");
        }
    }
}