using System.Collections.Generic;

namespace EFIntro.Models
{
    public class CustomerModel
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        
        // one-to-one 
        // navigation properties
        public ProfileModel Profile { get; set; }

        // relationship: many-to-many Customer ->---<- Product
        public List<CustomerProductModel> CustomerProduct { get; set; }
    }
    
}