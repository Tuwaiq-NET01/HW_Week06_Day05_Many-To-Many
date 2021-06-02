using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFIntro.Models
{
    public class BranchModel
    {
        public int Id { get; set; }
        [MaxLength]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string Area { get; set; }
        
        
        // relationship one-to-many Product -> -- Branch
        public List<ProductModel> Products { get; set; }
    }
}