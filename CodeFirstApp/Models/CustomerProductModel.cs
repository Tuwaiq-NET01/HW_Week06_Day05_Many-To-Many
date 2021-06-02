using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class CustomerProductModel
    {
        //to break many to many relationship
        public int id { get; set; }
        public CustomerModel Customer { get; set; }
        public ProductModel Product { get; set; }

        //two foreign keys
        public int CustomerId { get; set; }
        public int ProductId { get; set; }

    }
}
