using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCSQL.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [MaxLength(15)]
        public string LastName { get; set; }
        [MaxLength(15)]
        public string Email { get; set; }
        // navigation properties
        public ProfileModel Profile { get; set; }
        public List<CouponCustomer> CouponCustomer { get; set; }
    }

}