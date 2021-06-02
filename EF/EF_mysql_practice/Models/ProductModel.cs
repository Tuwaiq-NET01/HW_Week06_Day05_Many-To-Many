using System;
using System.Collections.Generic;

namespace EF_mysql_practice.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }

        //FK
        public int BranchId { get; set; }
        //navigation -- 1:M
        public BranchModel Branch { get; set; }

        public List<CustomerProductModel> CustomersProducts { get; set; }

    }
}
