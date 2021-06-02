using System;
using System.Collections.Generic;

namespace EF_mysql_practice.Models
{
    public class CustomerProductModel
    {
        public int Id { get; set; }

        public CustomerModel Customer { get; set; }
        public int CustomerId { get; set; }

        public ProductModel Product { get; set; }
        public int ProductId { get; set; }
    }
}
