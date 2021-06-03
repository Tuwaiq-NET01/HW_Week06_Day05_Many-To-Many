using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mvc_ef.Models
{
    public class Teacher
    {
        private static int auto_id = 1;
        public Teacher()
        {
            this.Id = ++auto_id;
        }
        [Key]
        public int Id {get; set;}
        [Required] //
        public string FullName { get; set; }
        public string Email {get; set;}
        public List<Student> studnets { get; set;}

    }
}
