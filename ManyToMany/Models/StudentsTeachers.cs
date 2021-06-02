using System;
using CodeFirst.Models;

namespace ManyToMany.Models
{
    public class StudentsTeachers
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
