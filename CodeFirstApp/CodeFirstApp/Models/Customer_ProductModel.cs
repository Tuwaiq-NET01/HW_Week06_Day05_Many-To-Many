using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    
    public class Customer_ProductModel
    {
        public int id { get; set; }

        public int customerId { get; set; }
        public CustomerModel CustomerModel { get; set; }

        
        public int productId { get; set; }
        public ProductModel ProductModel { get; set; }
    }
}
