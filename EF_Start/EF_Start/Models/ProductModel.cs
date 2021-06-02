using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Start.Models
{
    public class ProductModel
    {
        // prop
        public int Id { get; set; } 
        public string Name { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }

        // navication propetis : on-to-many: Products->--- Branch
        public int BranchId { get; set; }
        public BranchModels Branch { get; set; }

        // m2m

        public List<CustomerProductModel> CustomerProduct { get; set; }
    }
}
