namespace CodeFirstApp.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool Active { get; set; }
        
        // Navigation property with Customer
        public CustomersModel Customer { get; set; }
        // FK
        public int CustomerId { get; set; }
    }
}