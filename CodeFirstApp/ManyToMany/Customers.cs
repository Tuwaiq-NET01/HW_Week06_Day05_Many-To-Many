using System.Collections.Generic;

namespace CodeFirstApp.ManyToMany
{
    public class Customers
    {
        public int Id { get; set; }     
        public string Name { get; set; }

        public ICollection<CustomersProducts> CustomersProducts { get; set; }    }
}