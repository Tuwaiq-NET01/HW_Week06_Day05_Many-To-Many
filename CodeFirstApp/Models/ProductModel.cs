using System.Collections.Generic;

namespace CodeFirstApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }

        // Relationship One-To-Many  Branches ->-- Product
        public BranchModel Branch { get; set; }
        public int BranchId { get; set; }

        public List<CustomerProductModel> CustomerProduct { get; set; }

    }
}