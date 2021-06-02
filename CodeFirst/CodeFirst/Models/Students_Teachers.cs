using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Students_Teachers
    {
        public int Id { get; set; }
        // navigaion properties

        public Student Student { get; set; }
        public int StudentId { get; set; }//fk


        // navigaion properties

        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }//fk


    }
}
