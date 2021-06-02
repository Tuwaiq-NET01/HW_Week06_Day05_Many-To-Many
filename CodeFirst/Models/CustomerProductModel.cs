using System;
namespace CodeFirst.Models
{
    public class CustomerProductModel
    {
        public int CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
    }
}

