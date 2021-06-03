using System;
namespace CodeFirstApp.Models
{
    public class Custome_ProductModel
    {
        public int Id { get; set; }

        //navication proprties
        public int CustomerId { get; set; }
        //FK
        public CustomerModel Customer { get; set; }
        //navication proprties
        public int ProductId { get; set; }
        //FK
        public CustomerModel Product { get; set; }
    }
}
