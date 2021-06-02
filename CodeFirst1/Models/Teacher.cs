using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst1.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }


        public List<Subject> subjects { get; set; }
        public List<Teacher_Student> students_teachers { get; set; }

    }
}
