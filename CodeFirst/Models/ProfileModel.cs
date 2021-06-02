using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool Active { get; set; }

        //navigate property
        public CustomerModel Customer { get; set; }

        //FK
        public int CustomerId { get; set; }
    }
}
