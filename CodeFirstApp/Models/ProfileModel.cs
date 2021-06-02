namespace CodeFirstApp.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool Active { get; set; }

        // Navigations properties
        public CustomerModel Customer { get; set; }
        
        // Fk 
        public int CustomerId { get; set; }

    }
}