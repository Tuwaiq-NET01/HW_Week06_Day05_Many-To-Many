namespace CodeFirstApp.Models
{
    public class ProfileModel
    {
        public int Id {get;set;}
        public string Image { get; set; }
        public bool Active {get;set;} 
        
        // Navigation properties 
        public CustomerModel Customer {get;set;}
        // FK 
        public int CustomerId {get;set;}
        
    }
}