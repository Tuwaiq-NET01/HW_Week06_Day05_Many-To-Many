using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomType { get; set; }
        [Required]
        public bool Empty { get; set; }
        // public string Empty { get; set; }
        
        // Navigations properties
        public Student Student { get; set; }
        public int StudentId { get; set; } //FK
    }
}