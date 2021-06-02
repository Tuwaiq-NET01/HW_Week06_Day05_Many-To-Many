using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class BranchModel
    {
        public int ID { get; set; }
        [Required][MaxLength(30)]
        public string Name { get; set; }
        [Required] 
        public string Email { get; set; }
        public string Area { get; set; }
        //Relationship : one-To-Many: Branch
        public List<ProductModel> Products { get; set; }
    }
}
