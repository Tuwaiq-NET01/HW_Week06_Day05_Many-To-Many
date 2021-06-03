using System;
namespace SchoolMVCef.Models
{
    public class TeachModel
    {
        public int StudentId { get; set; }
        public StudentModel Student { get; set; }
        public int TeacherId { get; set; }
        public TeacherModel Teacher { get; set; }
    }
}
