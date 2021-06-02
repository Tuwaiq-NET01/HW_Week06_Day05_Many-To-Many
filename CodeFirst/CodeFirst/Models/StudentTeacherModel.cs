using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class StudentTeacherModel
    {
            public int StudentTeacherId { get; set; }

            public int StudentId { get; set; }
            public StudentModel Student { get; set; }

            public int TeacherId { get; set; }
            public TeacherModel Teacher { get; set; }
    }
}
