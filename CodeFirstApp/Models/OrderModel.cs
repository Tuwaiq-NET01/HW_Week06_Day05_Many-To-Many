using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class OrderModel
    {
        public int ID { get; set; }
        public string Descripton { get; set; }

        //Relationship : Many-To-Many: Product

        public List<Product_Order> Product_Orders { get; set; }
    }
}
