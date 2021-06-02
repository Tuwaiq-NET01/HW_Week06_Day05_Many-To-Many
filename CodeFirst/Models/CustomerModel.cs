using System;
using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ProfileModel Profile { get; set; }

        public List<CustomerProductModel> CustomerProducts { get; set; }
    }
}
