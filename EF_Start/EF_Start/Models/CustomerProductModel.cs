using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Start.Models
{
    public class CustomerProductModel
    {
        public int Id { get; set; }

        // navication propetis : many-to-many: Customer >----< Product

        public CustomerModel Customer { get; set; }
        public ProductModel Product { get; set; }

        // FK
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}
