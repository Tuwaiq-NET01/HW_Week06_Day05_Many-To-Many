namespace CodeFirst.Models
{
    public class SubjectModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
    }
}