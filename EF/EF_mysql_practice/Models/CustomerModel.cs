using System;
using System.Collections.Generic;

namespace EF_mysql_practice.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //navigation prop
        public ProfileModel Profile { get; set; }

        public List<CustomerProductModel> CustomersProducts { get; set; }
    }
}
