﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float  Price{ get; set; }
        public string Color { get; set; }
        public string type { get; set; }
        //relationship: one-to-many : product ->----- branch
        //fk
        public int BranchId { get; set; }
        public BranchModel Branch { get; set; }
        public List<Customers_Products> customer_products { get; set; }

    }
}
