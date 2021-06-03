using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp1.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }

        //Many-To-One relationship
        public BranchModel Branch { get; set; }
        public int BranchId { get; set; }

        //Many-To-Many
        public List<Order_ProductModel> OrderProduct { get; set; }
    }
}
