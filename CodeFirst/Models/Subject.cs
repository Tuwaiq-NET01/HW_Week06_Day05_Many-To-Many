using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string title { get; set; }


        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }

    }
}
