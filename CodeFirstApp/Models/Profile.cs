namespace CodeFirstApp.Models
{
    public class Profile
    {
        public int id { get; set; }
        public string image { get; set; }
        public bool active { get; set; }
        public Customer customer { get; set; }
        public int customerID { get; set; }
    }
}