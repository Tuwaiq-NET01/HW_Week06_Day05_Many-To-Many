using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string img { get; set; }
        public bool active { get; set; }
        public CustomerModel Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
