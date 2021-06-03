using System;
namespace CodeFirstApp.Models
{
    public class ProfileModel
    {
        public int id { get; set; }
        public string Img { get; set; }
        public bool Active { get; set; }

        //navication proprties
        public int CustomerId { get; set; }
        //FK
        public CustomerModel Customer { get; set; }
     }
}
