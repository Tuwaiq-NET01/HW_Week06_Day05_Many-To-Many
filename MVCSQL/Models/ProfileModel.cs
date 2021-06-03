using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MVCSQL.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool Active { get; set; }

        // navigation properties
        public CustomerModel Customer { get; set; }

        //FK
        public int CustomerId { get; set; }
    }
}
