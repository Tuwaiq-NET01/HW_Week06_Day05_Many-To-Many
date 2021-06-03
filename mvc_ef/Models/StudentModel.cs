using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace mvc_ef.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}
        public string Fname { get; set; }
        public string Lname {get; set;}
        public string Email {get; set;}
        public Room student_room {get; set;}
        public List<Teacher> teachers { get; set;}
    }
}
