using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }
        public ProfileModel Profile { get; set; }
        public List<Customers_Products> customer_products { get; set; }
    }
}
