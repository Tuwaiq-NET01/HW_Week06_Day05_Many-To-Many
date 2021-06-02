using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class Customer_ProductModel
    {
        public int id { get; set; }

        public CustomerModel Customer { get; set; }
        public ProductModel Product { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }


    }
}
