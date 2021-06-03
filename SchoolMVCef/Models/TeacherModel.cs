using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolMVCef.Models
{
    public class TeacherModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<TeachModel> Teach { get; set; }

    }
}
