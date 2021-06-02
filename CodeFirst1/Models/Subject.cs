using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst1.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        //Many Two One
        public Teacher teacher { get; set; }
        public int TeacherId { get; set; }

    }
}
