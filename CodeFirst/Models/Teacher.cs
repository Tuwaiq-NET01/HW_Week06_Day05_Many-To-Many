﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        //NAV PROP
        public List<Subject> subjects { get; set; } //1:M
        public List<StudentTeacher> StudentTeacher { get; set; }


    }

}
