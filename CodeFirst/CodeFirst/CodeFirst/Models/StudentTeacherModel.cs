using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class StudentTeacherModel
    {
        public int Id { get; set; }
        // navigation properties
        public Student Student { set; get; }
        public int StudentId { set; get; }//fk
        // navigation properties
        public Teacher Teacher { set; get; }
        public int TeacherId { set; get; } //fk


    }
}
