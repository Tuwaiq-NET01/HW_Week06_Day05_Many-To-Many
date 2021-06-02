using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFristApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }

        // Relationship : one-to-many : Product  ->------ Branch

        public int BranchId { get; set; }
        public BranchModel Branch { get; set; }

        public List<CostomerProductModel> CostomerProducts { get; set; }

    }
}
