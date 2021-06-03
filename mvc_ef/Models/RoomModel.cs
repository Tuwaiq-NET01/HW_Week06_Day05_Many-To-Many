using System;

namespace mvc_ef.Models
{
   public enum RoomType
    {
        t1,
        t2,
        t3,
    }
    public class Room
    {
        public int Id {get; set;}
        public RoomType _RoomType { get; set; }
        public bool Empty {get; set;}
    }

}
