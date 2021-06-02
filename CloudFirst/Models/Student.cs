using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CloudFirst.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //Navigatuins propeties
        public Room Room { get; set; }
        //many2many with studentteacher
        public List<StudentTeacher> StudentTeachers { get; set; }

    }
}
