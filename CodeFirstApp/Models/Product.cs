using System.Collections.Generic;

namespace CodeFirstApp.Models
{
    public class Product
    {
        public Product(){}
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string color { get; set; }
        
        
   
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        
        

    }
}