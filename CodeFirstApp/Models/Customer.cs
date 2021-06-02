using System.Collections.Generic;

namespace CodeFirstApp.Models
{
    public class Customer
    {

        public int id { get; set; }
        public string firstName { get; set; }
        public string lasName { get; set; }
        public string email { get; set; }
        

        public Profile profile { get; set; }
    }
}