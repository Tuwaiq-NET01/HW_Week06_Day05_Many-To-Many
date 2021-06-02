using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApp.Models
{
    public class BranchModel
    {
        public int Id { get; set; }
        [Required] public string Address { get; set; }
        [MaxLength(32)]  public string Name { get; set; }
        public string Area { get; set; }

        
        //Relationship One-To-Many  Branches --<- Product
        public List<ProductModel> Product { get; set; }
        
    }
}