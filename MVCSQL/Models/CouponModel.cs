using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MVCSQL.Models
{
    public class CouponModel
    {
        public int Id { get; set; }
        public DateTime Expiry { get; set; }
        public string CodeSale { get; set; }
        public List<CouponCustomer> CouponCustomer { get; set; }
    }
}
