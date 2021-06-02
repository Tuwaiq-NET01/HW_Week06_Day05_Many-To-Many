using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //one to one relationship
        public ProfileModel Profile { get; set; }

        // relationship to the new table to break the many to many relationship.
        public List<CustomerProductModel> CustomerProduct { get; set; }

    }
}
