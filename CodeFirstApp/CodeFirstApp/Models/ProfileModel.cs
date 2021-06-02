using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string Imaage { get; set; }
        public bool Active { get; set; }


        //Relationship

        public CustomerModel Customer { get; set; }

        //FK 
        public int CustomerId { get; set; }

    }
}
