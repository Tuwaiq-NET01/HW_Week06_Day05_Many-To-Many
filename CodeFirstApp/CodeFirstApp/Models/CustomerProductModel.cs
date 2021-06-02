namespace CodeFirstApp.Models
{
    public class CustomerProductModel
    {
        public int Id { get; set; }
        
        // Navigation properties  many-to-many Customer ->--<- Product
        public CustomerModel Customer { get; set; }
        public ProductModel Product { get; set; }

        // FKs
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}