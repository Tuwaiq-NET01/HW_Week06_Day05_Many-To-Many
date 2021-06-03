using System;
namespace CodeFirstApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }

        //navication proprties
        public int BrancheId { get; set; }
        //FK
        public BranchModel Branch { get; set; }

    }
}
