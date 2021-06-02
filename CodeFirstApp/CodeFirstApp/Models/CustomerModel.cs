﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstApp.Models;

namespace CodeFirstApp.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ProfileModel Profile { get; set; }



        public List<Customer_ProductModel> Customer_ProductModel { get; set; }
    }
}
