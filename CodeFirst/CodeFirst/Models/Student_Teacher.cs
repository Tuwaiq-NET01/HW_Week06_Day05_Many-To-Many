namespace CodeFirst.Models
{
    public class Student_Teacher
    {
        public int Id { get; set; }
        
        public Student Student { get; set; }
        public int StudentId { get; set; }
        
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        
    }
}