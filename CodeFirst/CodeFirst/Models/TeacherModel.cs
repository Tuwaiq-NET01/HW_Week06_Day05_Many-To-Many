using System;
using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class TeacherModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Eamil { get; set; }


        //navagation subject table
        public List<SubjectModel> Subjects { get; set; }


        //navagation Properties table StudentToTeacher Many-to-Many

        public List<StudentToTeacherModel> StudentsToTeachers { get; set; }
    }

}
