using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManyToMany.Data;
using ManyToMany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ManyToMany.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<StudentTeacher> Get()
        {
            return _context.Student_Teacher.ToList();
        }
    }
}
