using System;
namespace CodeFirst.Models
{
    public class SubjectModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        //navagation Teacher table
        public int TeacherId { get; set; }//FK
        public TeacherModel Teacher { get; set; }
        


    }
}
