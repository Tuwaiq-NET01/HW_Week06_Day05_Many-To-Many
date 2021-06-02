using System.Collections.Generic;
using CodeFirstApp.Models;

namespace CodeFirstApp.ManyToMany
{
    public class Products
    {
        public int Id { get; set; }     
        public string Name { get; set; }

        public ICollection<CustomersProducts> CustomersProducts { get; set; }    }
}