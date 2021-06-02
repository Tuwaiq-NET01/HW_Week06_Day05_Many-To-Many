using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudFirst.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        //Subjectsss
        public List<Subject> Subjects { get; set; }
        //many2many with studentteacher
        public List<StudentTeacher> StudentTeachers { get; set; }
    }
}
