using System.Collections.Generic;

namespace ManyToMany.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<StudentTeacher> TeacherStudents { get; set; }
    }
}