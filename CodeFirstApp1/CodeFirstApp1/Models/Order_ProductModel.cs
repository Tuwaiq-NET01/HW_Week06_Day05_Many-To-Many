using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp1.Models
{
    public class Order_ProductModel
    {
        public int Id { get; set; }

        public ProductModel Product { get; set; }
        public int ProductId { get; set; }

        public OrdersModel Order { get; set; }
        public int OrderId { get; set; }

    }
}
