using CodeFirstApp.Data;
using CodeFirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Controllers
{
    public class BranchesController : Controller
    {
        private readonly AppDbContext appDbContext;

        public BranchesController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            ViewData["Branches"] = this.appDbContext.Branches.ToList();
            return View();
        }

    }
}
