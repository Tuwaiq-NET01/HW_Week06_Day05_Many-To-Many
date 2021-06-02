using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFristApp.Models
{
    public class CostomerProductModel
    {
        public int Id { get; set; }


        public ProductModel Product { get; set; }
        public CostomerModel Costomer { get; set; }
        public int CostomerId { get; set; }
        public int ProductId { get; set; }
    }
}
