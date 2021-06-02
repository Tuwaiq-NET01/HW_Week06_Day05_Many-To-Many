using System;
using System.Collections.Generic;
using ManyToMany.Models;

namespace CodeFirst.Models
{
    public class Teacher
    {

        public int Id { get; set; }
        public string FullName { get; set; }
        public int age { get; set; }

        //Navigation properties
        public ICollection<StudentsTeachers> Students { get; set; } // many to many

    }
}
