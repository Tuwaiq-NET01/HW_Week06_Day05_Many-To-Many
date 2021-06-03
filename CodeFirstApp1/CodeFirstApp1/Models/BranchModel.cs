using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp1.Models
{
    public class BranchModel
    {
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        public int Area { get; set; }

        //One-To-Many RelationShip 
        public List<BranchModel> Products { get; set; }
    }
}
