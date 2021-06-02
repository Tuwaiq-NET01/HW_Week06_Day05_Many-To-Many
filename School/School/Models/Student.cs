using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Profile Profile { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public IList<StudentTeacher> StudentTeachers { get; set; }

    }
}
