using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class Teacher
    {
        public int Id { set; get; }
        public string FullName { set; get; }
        public string Email { set; get; }
        
        public List<SubjectModel> Subject { get; set; }
        
        
    }
}