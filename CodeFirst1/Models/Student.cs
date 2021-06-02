using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public Room room { get; set; }
        public List<Teacher_Student> students_teachers { get; set; }

    }
}
