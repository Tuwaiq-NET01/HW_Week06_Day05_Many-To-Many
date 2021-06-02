using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class RoomModel
    {
        [Key]
        public int Id { set; get; }
        [Required]
        public bool Empty { set; get; }
        public int Number { set; get; }

        public StudentModel Student { set; get; }
        public int StudentId { set; get; } //FK

    }
}
