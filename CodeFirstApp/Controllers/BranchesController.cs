using System;
using System.Linq;
using CodeFirstApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApp.Controllers
{
    public class BranchesController : Controller
    {
        private readonly AppDbContext _context;

        public BranchesController(AppDbContext context)
        {
            this._context = context;
        }
        
        // GET
        public IActionResult Index()
        {
            var customers = this._context.Customers.ToList();
            ViewData["customers"] = customers;

            var customerId = this._context.Customers.SingleOrDefault(a => a.Id == 2);
            ViewData["CustomerId"] = customerId;

            var greaterThanTwo = this._context.Customers.Where(a => a.Id > 2).ToList();
            ViewData["GreaterThanTwo"] = greaterThanTwo;

            
            return View();
        }

        public IActionResult Search(string txt)
        {
            var searchCustomers = this._context.Customers.Where(a => a.LastName.Contains(txt) ||a.FirstName.Contains(txt) ).ToList();
            ViewData["SearchCustomers"] = searchCustomers;
            
            return View("Index");
        }
        
    }
}