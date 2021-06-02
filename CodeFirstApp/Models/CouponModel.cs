using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class CouponModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime ExpiryDate { get; set; }
        public List<CouponCustomer> CouponCustomer { get; set; }
    }
}
    