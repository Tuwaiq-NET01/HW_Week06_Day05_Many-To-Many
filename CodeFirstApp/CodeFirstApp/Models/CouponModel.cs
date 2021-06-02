using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class CouponModel
    {
        public int Id { get; set; }
        public string CouponCode { get; set; }
        public int DiscountValue { get; set; }

        public List<Customer_CouponModel> Customer_Coupon { get; set; }
    }
}
