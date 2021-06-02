using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeFirst.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeFirst.Controllers
{
    public class ProductsController : Controller
    {
        private readonly CodeFirst.Data.AppDbContext _context;

        public ProductsController(CodeFirst.Data.AppDbContext context)
        {
            _context = context;
        }


        [BindProperty]
        public List<ProductModel> Products { get; set; }


        // GET: /<controller>/
        public IActionResult Index()
        {
            Products = _context.Products.ToList();
            ViewBag.Products = Products;
            return View();
        }
    }
}
