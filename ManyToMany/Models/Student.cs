using System;
using System.Collections.Generic;
using ManyToMany.Models;

namespace CodeFirst.Models
{
    public class Student
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        //Navigation properties
        public ICollection<StudentsTeachers> Teachers { get; set; } //many to many
    }
}
