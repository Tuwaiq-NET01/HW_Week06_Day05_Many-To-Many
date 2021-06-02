using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    
    public class Student
    {

        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email {get; set;}

        //Navigations proprties
        public roomModel room { get; set; }

        public List<Student_teacher> Student_teacher { get; set; }


    }
}
