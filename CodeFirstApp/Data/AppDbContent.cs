using CodeFirstApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Branch> Branches { get; set; }
        
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<CustomerProducts> CustomerProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<Customer>().HasData(new Customer {id = 1, firstName = "riydah", lasName = "dkdk", email = "branch1"});
            modelBuilder.Entity<Customer>().HasData(new Customer {id = 2, firstName = "hel", lasName = "dkdwewek", email = "branch1"});
            modelBuilder.Entity<Customer>().HasData(new Customer {id = 3, firstName = "ss", lasName = "wewedkdk", email = "branch1"});
            modelBuilder.Entity<Branch>().Property(b => b.Area).IsRequired();
            modelBuilder.Entity<Branch>().HasData(new Branch {Id = 1, Address = "riydah", Area = "dkdk", Name = "branch1"});
            modelBuilder.Entity<Branch>().HasData(new Branch {Id = 2, Address = "riydah", Area = "dkdk", Name = "branch 2"});
            modelBuilder.Entity<Branch>().HasData(new Branch {Id = 3, Address = "riydah", Area = "dkdk", Name = "branch 3"});
            modelBuilder.Entity<Branch>().HasData(new Branch {Id = 4, Address = "riydah", Area = "dkdk", Name = "branch 4"});
            modelBuilder.Entity<Branch>().HasData(new Branch {Id = 5, Address = "riydah", Area = "dkdk", Name = "branch 5"});
            modelBuilder.Entity<Branch>().HasData(new Branch {Id = 6, Address = "riydah", Area = "dkdk", Name = "branch 6"});
        */
        }
    }
}