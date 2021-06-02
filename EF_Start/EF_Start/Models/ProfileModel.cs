using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Start.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool Active { get; set; }

        // navication propetis
        public CustomerModel Customer { get; set; }
        //FK
        public int CustomerID { get; set; }
    }
}
