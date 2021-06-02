using System;
using System.ComponentModel.DataAnnotations;

namespace ManyToMany.Models
{
    public class CustomerProduct
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}
