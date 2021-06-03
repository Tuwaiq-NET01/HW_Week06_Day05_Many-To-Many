using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class BranchModel
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Area { get; set; }


        // Relationship : one to many  branches-> product
        public List<ProductModel> Products { get; set; }


    }

}
