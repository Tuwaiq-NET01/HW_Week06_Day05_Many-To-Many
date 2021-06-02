using System;
using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }

        public BranchModel Branch { get; set; }

        public List<CustomerProductModel> CustomerProducts { get; set; }

    }
}
