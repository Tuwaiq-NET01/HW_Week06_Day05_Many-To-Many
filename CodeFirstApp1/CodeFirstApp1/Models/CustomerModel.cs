using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp1.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        public string Email { get; set; }

        public ProfileModel Profile { get; set; }
    }
}
