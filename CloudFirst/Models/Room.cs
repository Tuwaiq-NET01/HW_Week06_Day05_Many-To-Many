using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudFirst.Models
{
    public class Room
    {
        // [key]
        public int Id { get; set; }
        [Required]
        public bool Empty { get; set; }
        public int RoomNumber {get; set;}
        public string RoomType { get; set; }

        // navigation
        public Student Student { get; set;  }
        public int StudentId { get; set; } // FK

    }
}
