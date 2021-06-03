using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApp.Models
{
    public class BranchModel
    {
            public int id { get; set; }
         [Required]
            public string Name { get; set; }
            public string Adress { get; set; }
        [MaxLength(20)]
            public string Area { get; set; }

        //RelationShip
        public List<ProductModel> Products { get; set; }
    }
}
