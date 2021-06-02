using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst1.Models
{
    public class Room
    {
        public int Id { get; set; }
        public bool Empty { get; set; }
        public int RoomNumber { get; set; }
        public int StudentId { get; set; }
        public Student Students { get; set; }
     


    }
}
