using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApp.Models
{
    public class ProductModel
    {
        
        public int Id { get; set; } 
        
        [Required]
        public string Name { get; set; }
        public float price { get; set; }
        public string Color { get; set; }
        
        
        // Relationships : one-To-Many  
        public int BranchID {get;set;}
        public BranchModel Branch {get;set;} 
        
        // Relationships : Many-To-Many
        public List<CustomerProductModel> CustomerProduct { get; set; }
    }
}