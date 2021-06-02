using System;
using Microsoft.EntityFrameworkCore;
using CodeFirstApp.Models;

namespace CodeFirstApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 

        }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<BranchModel> Branches { get; set; }

        public DbSet<ProfileModel> Profiles { get; set; }
        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 1, Address = "Riyadh", 
                Area = "Almansorea", Name = "Mansour" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
            {
                Id = 2,
                Address = "Dammam",
                Area = "Mansovic",
                Name = "BranchA"
            });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
            {
                Id = 3,
                Address = "Jed",
                Area = "Jaded",
                Name = "BranchB"
            });


            // Add to customers table:

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel
            {
                Id = 1,
                FirstName = "Mansour",
                LastName = "Ruosnam",
                Email = "23askda@masd.com"
            });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel
            {
                Id = 2,
                FirstName = "Manso",
                LastName = "osnaM",
                Email = "23@me.com"
            });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel
            {
                Id = 3,
                FirstName = "M",
                LastName = "Man",
                Email = "a@a.com"
            });
        }

    }
}
