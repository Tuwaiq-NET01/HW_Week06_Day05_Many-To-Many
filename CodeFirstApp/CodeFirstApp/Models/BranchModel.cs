using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class BranchModel
    {
        public int Id { get; set; }
        [Required]
        public string Adress { get; set; }
        [MaxLength(20)]
        public string  Name { get; set; }
        public string Area { get; set; }

        //Relationship: one-to-many: Branch -----<- product
        public List<ProductModel> Products { get; set; }
    }
}
