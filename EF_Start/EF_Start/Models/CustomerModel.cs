using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Start.Models
{
    public class CustomerModel
    {
        // prop
        public int Id { get; set; } 
        public string Name { get; set; }

        // navication propetis
        public ProfileModel Profile { get; set; }

        // m2m

        public List<CustomerProductModel> CustomerProduct { get; set; }
    }
}
