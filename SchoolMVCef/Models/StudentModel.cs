using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolMVCef.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public List<TeachModel> Teach { get; set; }
    }
}
