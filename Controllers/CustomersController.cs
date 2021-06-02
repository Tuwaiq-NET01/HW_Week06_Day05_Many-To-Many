using CodeFirstApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AppDbContext _db; // معناها سوي اكسز لكل الديبيز اللي موجوده بالكونتكست يعني يمديك توصل لايمودل زي الكستومر وغيره حتى من هنا 

        // نسوي كونستركتر عشان اول ما يدخل للكونترولر يتنفذ هذا الشئ 
        public CustomersController(AppDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var Customers = _db.Customers.ToList();
            ViewData["Customers"] = Customers;
            return View();
        }
    }
}
