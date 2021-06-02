using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstApp.Data;

namespace CodeFirstApp.Controllers
{
    public class BranchesController : Controller
    {
        private readonly AppDbContext _db; // معناها سوي اكسز لكل الديبيز اللي موجوده بالكونتكست يعني يمديك توصل لايمودل زي الكستومر وغيره حتى من هنا 

        // نسوي كونستركتر عشان اول ما يدخل للكونترولر يتنفذ هذا الشئ 
        public BranchesController(AppDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var searchbyId = _db.Branches.SingleOrDefault(a => a.Id == 2).Address; // يجيب لك الادرس من الداتا بيس Singleordefault , Firstordefault ,Lastordefault
            var searchbygr = _db.Branches.Where(a => a.Id >=3).ToList(); // Where يمكن يجيب لك اكثرمن عنصر فنستخدم ليست
            ViewData["sId"] = searchbyId;
            ViewData["Gr"] = searchbygr;

            var Branches = _db.Branches.ToList();
            ViewData["Branches"] = Branches;
            return View();
        }
       /* public IActionResult Search(string txt)
        {
            var aa = _db.Branches.Where(a => a.Address.Contains(txt)).ToList();
            ViewData["aa"] = aa;
            return View("Index"); // خطا ترسل 2 اكشنز ل ون فيو 
        }*/
    }
}
