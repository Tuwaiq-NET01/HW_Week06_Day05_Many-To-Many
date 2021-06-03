using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectWithMySQL.Models
{
    public class Room
    {
       public int Id { get; set; }
        
       public String RoomType { get; set; }
        [Required]
        public bool Empty { get; set; }

        //
        public Student student { get; set; }
        public int StudentId { get; set; }
    }
}
