using System;
namespace ProjectWithMySQL.Models
{
    public class Student_teacher
    {
        public int id{get;  set; }
        public int StudentId { get; set; }
        public Student student { get; set; }
        public int TeacherId { get; set; }
        public Teacher teacher { get; set; }
    }
}
