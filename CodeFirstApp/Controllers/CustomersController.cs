using CodeFirstApp.Data;
using CodeFirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AppDbContext appDbContext;

        public CustomersController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            ViewData["ErrorMessage"] = HttpContext.Request.Query["err_msg"].ToString();
            //ViewData["Customers"] = this.appDbContext.Customers.ToList();
            ViewData["Customers"] = this.appDbContext.Customers.Where(p => p.Id > 2).ToList();
            //ViewData["CustomerFirstName"] = this.appDbContext.Customers.FirstOrDefault(p => p.Id == 2)?.FirstName;
            ViewData["CustomerFirstName"] = this.appDbContext.Customers.SingleOrDefault(p => p.Id == 100)?.FirstName;
            return View();
        }

        public IActionResult Search()
        {
            var query = HttpContext.Request.Query["q"].ToString();

            if (string.IsNullOrEmpty(query)) return Redirect("~/Customers/Index");

            ViewData["Customers"] = this.appDbContext.Customers.Where(p => p.FirstName == query).ToList();

            if (((List<CustomerModel>)ViewData["Customers"]).Count == 0) return Redirect("~/Customers/Index?err_msg=No match");

            return View("~/Views/Customers/Index.cshtml");
        }
    }
}
