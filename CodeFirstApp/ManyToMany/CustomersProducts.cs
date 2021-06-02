using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApp.ManyToMany
{
    public class CustomersProducts
    {
        public int Id { get; set; }
        
        public int CustomerId { get; set; }     
        public Customers Customers { get; set; }
        
        public int ProductId { get; set; }     
        public Products Products { get; set; }
    }
}