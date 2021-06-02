using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomType { get; set; }
        [Required]
        public bool Empty { get; set; }

        //Navigation properties
        public int StudentId { get; set; }
        public Student Student { get; set; }

    }
}
