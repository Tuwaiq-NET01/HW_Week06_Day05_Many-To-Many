using System;
namespace EF_mysql_practice.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool Active { get; set; }

        //navigation properties
        public CustomerModel Customer { get; set; }
        //FK
        public int CustomerId { get; set; }
    }
}
