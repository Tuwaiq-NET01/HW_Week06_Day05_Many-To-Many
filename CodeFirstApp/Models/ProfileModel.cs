using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class ProfileModel
    {
        public int id { get; set; }
        public string img { get; set; }
        public bool active { get; set; }

        //One to one relationship
        public CustomerModel Customer { get; set; }
        //Foreign key of Customers table.
        public int CustomerId { get; set; }
    }
}
