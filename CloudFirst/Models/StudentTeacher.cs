using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudFirst.Models
{
    public class StudentTeacher
    {
        public int Id { get; set; } // Pk
        public Student Student { get; set; }
        public int StudentId { get; set; } // Fk
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; } //Fk
    }
}
