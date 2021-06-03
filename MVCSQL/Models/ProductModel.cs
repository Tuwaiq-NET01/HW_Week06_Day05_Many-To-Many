using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace MVCSQL.Models
{
  
        public class ProductModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            [MaxLength(20)]
            public string Color { get; set; }

            [MaxLength(20)]
            public float Price { get; set; }

        // One-To-Many: Products => Branch
        public BranchModel Branch { get; set; }

        //FK
        public int BranchId { get; set; }
    }
    }
