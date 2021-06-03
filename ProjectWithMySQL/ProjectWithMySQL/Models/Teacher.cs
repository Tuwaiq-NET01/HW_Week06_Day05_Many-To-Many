using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectWithMySQL.Models
{
    public class Teacher
    {
        public int id
        {
            get;
            set;

        }
        [Required]
        public String Name
        {
            get;
            set;

        }
        public ICollection<Student_teacher> student_teacher_list { get; set; }
    }
}
