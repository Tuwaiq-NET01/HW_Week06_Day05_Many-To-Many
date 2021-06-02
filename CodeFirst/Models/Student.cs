using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
        // Navigations properties
        public Room Room { get; set; }
        
        public List<StudentTeatcher> Student_Teatcher { get; set; }
    }
}