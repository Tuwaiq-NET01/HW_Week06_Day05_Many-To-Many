using System;
using System.ComponentModel.DataAnnotations;

namespace ManyToMany.Models
{
    public class StudentTeacher
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
    }
}
