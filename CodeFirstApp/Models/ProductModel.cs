using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class ProductModel
    {
        [Required]
        public int ID { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }

        //Relationship : one-To-Many: Products
        public BranchModel Branch { get; set; }
        public int BranchID { get; set; }

        //Relationship : Many-To-Many: Orders
        public List<Product_Order> Product_Orders { get; set; }

    }
}
