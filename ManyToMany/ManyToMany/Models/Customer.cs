using System;
using System.ComponentModel.DataAnnotations;

namespace ManyToMany.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
    }
}
