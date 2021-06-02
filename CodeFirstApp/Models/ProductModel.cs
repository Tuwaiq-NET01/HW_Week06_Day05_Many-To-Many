using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }

        //one to many relationship
        public BranchModel Branch { get; set; }
        public int BranchId { get; set; }

        // relationship to the new table to break the many to many relationship.
        public List<CustomerProductModel> CustomerProduct { get; set; }
    }
}
