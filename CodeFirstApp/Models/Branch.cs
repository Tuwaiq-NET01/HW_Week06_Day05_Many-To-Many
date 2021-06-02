using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApp.Models
{
    public class Branch
    {
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        
        public List<Product> Products { get; set; }

    }
}