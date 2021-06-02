using System.Collections.Generic;
using System.Security.Principal;

namespace ManyToMany.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<StudentTeacher> StudentTeachers { get; set; }
    }
}