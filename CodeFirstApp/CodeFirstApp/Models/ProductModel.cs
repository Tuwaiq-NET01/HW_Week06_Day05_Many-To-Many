using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstApp.Models;

namespace CodeFirstApp.Models
{
    public class ProductModel
    { //every product belogens one branch
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }

        public List<Customer_ProductModel> Customer_ProductModel { get; set; }

        public int BranchId { get; set; }

        public BranchModel Branch { get; set; }
    }
}
