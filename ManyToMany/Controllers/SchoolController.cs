using ManyToMany.Data;
using ManyToMany.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManyToMany.Controllers
{
    public class SchoolController : Controller
    {
        private MainContext Context;
        
        public SchoolController(MainContext context)
        {
            this.Context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult add()
        {
            Student student = new Student();
            Teacher teacher = new Teacher();
            StudentTeacher studentTeacher = new StudentTeacher();
            studentTeacher.Student = student;
            studentTeacher.Teacher = teacher;
            
            this.Context.Students.Add(student);
            this.Context.Teachers.Add(teacher);
            this.Context.StudentsTeachers.Add(studentTeacher);
            this.Context.SaveChanges();
            return Ok();
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }
    }
}