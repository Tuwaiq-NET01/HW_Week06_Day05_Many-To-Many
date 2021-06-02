namespace CodeFirst.Models
{
    public class StudentTeatcher
    {
        public int Id { get; set; } // Pk
        public Student Student { get; set; }
        public int StudentId { get; set; } // Fk
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; } //Fk
    }
}