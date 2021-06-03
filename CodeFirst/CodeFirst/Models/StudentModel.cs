using System;
using System.Collections.Generic;


namespace CodeFirst.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Eamil { get; set; }

        //Navagation Properties
        public RoomModel Room { get; set; }//to create relation 1 to 1


        //navagation Properties table StudentToTeacher Many-to-Many
        public List<StudentToTeacherModel> StudentsToTeachers { get; set; }

       

   
    }
}
