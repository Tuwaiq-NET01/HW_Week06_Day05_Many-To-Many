using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }

        
        //Relationship: One-to-many: Products ->--- Branch
        public int BanchId { get; set; }
        public BranchModel Branch { get; set; }
        
       

    }
}
