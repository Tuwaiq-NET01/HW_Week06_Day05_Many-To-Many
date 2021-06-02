using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class RoomModel
    {
        public int Id { set; get; }
        [Required]
        public bool Empty { set; get; }
        public int RoomNumber{ set; get; }
        public int StudentId { set; get; }
        public StudentModel Student { set; get; }
    }
}
