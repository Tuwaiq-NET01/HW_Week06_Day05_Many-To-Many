using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManyToMany.Models
{
    [Table("studentsteachers")]
    public class StudentTeacher
    {
        public int ID { get; set; }
        
        public int StudentId { get; set; }
        public Student Student { get; set; }
        
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}