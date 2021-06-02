using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        
        // Navigations properties
        public List<StudentTeatcher> Student_Teatcher { get; set; }
    }
}