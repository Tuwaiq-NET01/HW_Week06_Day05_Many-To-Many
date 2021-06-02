namespace CodeFirst.Models
{
    public class Student
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        
        // Navigations properties
        public RoomModel Room { get; set; }
    }
}