using System.Collections.Generic;

namespace CodeFirstApp.Models
{
    public class CustomerModel
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }

        // Navigations properties
        public ProfileModel Profile { get; set; }

        public List<CustomerProductModel> CustomerProduct { get; set; }
    }
}