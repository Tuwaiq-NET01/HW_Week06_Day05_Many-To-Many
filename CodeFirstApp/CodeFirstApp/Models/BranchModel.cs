using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApp.Models
{
    public class BranchModel
    {
        
        public int id { get; set; }
        [Required]
        public string Address { get; set; }
        [MaxLength(20)]
        public string  Name { get; set; }
        public int Area { get; set;  }
        
        
        // Relationship : one to Many  ---<- 
        public List<ProductModel> Products {get;set;}
        
            
            
            
    }
}