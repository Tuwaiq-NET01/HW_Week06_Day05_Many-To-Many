using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //Navigation
        public Room Room { get; set; }
       

    }
}
