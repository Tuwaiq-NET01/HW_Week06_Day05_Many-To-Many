namespace CodeFirstApp.Models
{
    public class CustomersModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
        // Navigation properties with Profile
        public ProfileModel Profile { get; set; }
    }
}