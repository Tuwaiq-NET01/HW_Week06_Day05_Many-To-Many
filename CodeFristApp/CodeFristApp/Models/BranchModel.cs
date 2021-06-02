using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFristApp.Models
{
    public class BranchModel
    {
        public int Id {  get; set; }
        [Required]
        public string Addres { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }

        public string Area { get; set; }


        // Relationship : one-to-many Branch ------<- Product
        public List<ProductModel> Products { get; set; }

    }
}
