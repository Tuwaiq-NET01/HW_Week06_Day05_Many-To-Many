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

        //practice: delete a field AFTER you update the DB.
        [MaxLength(20)]
        public string RoomType { get; set; }

        [Required]
        public bool Empty{ get; set; }
        public int RoomNumber { get; set; }

        //NAVIGATION PROPERTIES 
        public Student Student { get; set; } //FK
        public int StudentId { get; set; } //FK


    }
}
