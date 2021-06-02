namespace EFIntro.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string Image { get; set; }

        public bool Active { get; set; }
        
        // nav props
        public CustomerModel Customer { get; set; }
        // one-to-one
        //FK
        public int CustomerId { get; set; }
    }
}