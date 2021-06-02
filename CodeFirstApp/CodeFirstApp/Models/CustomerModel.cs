using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //Navigation Properties
        public ProfileModel Profile { get; set; } // to link the two tables

        public List<Customer_CouponModel> Customer_Coupon { get; set; }

    }
}
