using System.Collections.Generic;

namespace CodeFirstApp.Models
{
    public class CustomerModel
    {
        public int id { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set;  }
        public string Email { get; set; }
        
        // Navigation properties 
        public ProfileModel Profile {get;set;} 
        
        // Many to many 
        public List<CustomerProductModel> CustomerProduct { get; set; }

    }
}