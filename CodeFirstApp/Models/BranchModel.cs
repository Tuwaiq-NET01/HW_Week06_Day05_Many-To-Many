using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class BranchModel
    {
        public int id { get; set; }
        [Required]
        public string Address { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public string Area { get; set; }

        // Relationship One-To-Many
        public List<ProductModel> Products { get; set; }
    }
}
