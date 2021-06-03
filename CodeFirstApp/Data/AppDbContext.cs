using System;
using Microsoft.EntityFrameworkCore;
using CodeFirstApp.Models;
using CodeFirstApp.Data;

namespace CodeFirstApp.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<BranchModel> Branches { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<Custome_ProductModel> Customer_Product { get; set; }


        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();

            //seeding Branches
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { id = 1, Name = "Branche01", Adress = "Riydh", Area = "alnakuli" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { id = 2, Name = "Branche02", Adress = "Jeedah", Area = "alnakuli" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { id = 3, Name = "Branche03", Adress = "makkah", Area = "alnakuli" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { id = 4, Name = "Branche04", Adress = "madinah", Area = "alnakuli" });

            //seeding custumer
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 1, FirstName = "afra", LastName = "allahyani", Email = "@afraa" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 2, FirstName = "sara", LastName = "sara", Email = "@sara" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 3, FirstName = "nora", LastName = "nora", Email = "@nora" });

        }



    }
}

