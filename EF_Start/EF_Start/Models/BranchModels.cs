using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Start.Models
{
    public class BranchModels
    {
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }

        // navication propetis : on-to-many: Branch---<- Products
        public List<ProductModel> Products { get; set; }
    }
}
