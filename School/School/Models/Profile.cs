using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string Image { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
