using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp1.Models
{
    public class OrdersModel
    {
        public int Id { get; set; }
        public float Price { get; set; }

        //Many-To-Many
        public List<Order_ProductModel> OrderProduct { get; set; }
    }
}
