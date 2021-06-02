using System.Collections.Generic;

namespace EFIntro.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }
        
        
        // relationship: one-to-many Product -> -- Branch
        // FK
        public int BranchId { get; set; }
        // nav prop
        public BranchModel Branch { get; set; }
        
        // relationship: many-to-many Customer ->---<- Product
        public List<CustomerProductModel> CustomerProduct { get; set; }
    }
}