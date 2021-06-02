using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }

        public DbSet<BranchModel> Branchs { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<Customer_ProductModel> Customers_Products { get; set; }


        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();

            //Seeding
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { id = 1, Address = "Riyadh", Area = "Alnakuli", Name = "Branch01" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { id = 2, Address = "Riyadh", Area = "Alnakuli", Name = "Branch02" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { id = 3, Address = "Riyadh", Area = "Alnakuli", Name = "Branch03" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { id = 4, Address = "Riyadh", Area = "Alnakuli", Name = "Branch04" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { id = 5, Address = "Riyadh", Area = "Alnakuli", Name = "Branch05" });


            //Customer

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { id = 1,FirstName = "Abdulrahman",LastName="Aljfar",Email= "AbdulrahmanJ@gmail.com" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { id = 2,FirstName = "Abdulrahman",LastName="Aljfar",Email= "AbdulrahmanJ@gmail.com" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { id = 3,FirstName = "Abdulrahman",LastName="Aljfar",Email= "AbdulrahmanJ@gmail.com" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { id = 4,FirstName = "Abdulrahman",LastName="Aljfar",Email= "AbdulrahmanJ@gmail.com" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { id = 5,FirstName = "Abdulrahman",LastName="Aljfar",Email= "AbdulrahmanJ@gmail.com" });



        }
    }
}
