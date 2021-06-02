using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class StudentTeacherModel
    {
        public int Id { set; get; }
        public int TeacherId { set; get; }
        public TeacherModel Teacher { set; get; }
        public int StudentId { set; get; }
        public StudentModel Student { set; get; }
    }
}
