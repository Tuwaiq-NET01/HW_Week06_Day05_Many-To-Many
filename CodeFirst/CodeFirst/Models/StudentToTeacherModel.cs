using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;



namespace CodeFirst.Models

{
    public class StudentToTeacherModel
    {
        
        
        public int StudentId { get; set; }//FK
        //navagation Properties table student Many-to-Many
        public StudentModel Students { get; set; }



        public int TeacherId { get; set; }//FK
        //navagation Properties table teacher Many-to-Many
        public TeacherModel Teachers { get; set; }
        

    }
}