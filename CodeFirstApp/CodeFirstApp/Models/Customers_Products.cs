using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class Customers_Products
    {
        public int Id { get; set; }

        //FK
        public  int CustomrId { get; set; }
        public Customer  Customer{ get; set; }

        //FK
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
    }
}
