namespace CodeFirstApp.Models
{
    public class CustomerProducts
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Branch { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}