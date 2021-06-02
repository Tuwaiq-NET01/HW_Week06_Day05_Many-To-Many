using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirstApp.Models;

namespace CodeFirstApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<ProductModel> Products { get; set; }

        public DbSet<BranchModel> Branches { get; set; }

        public DbSet<ProfileModel> Profiles { get; set; }

        public DbSet<Customer_ProductModel> Customer_Product { get; set; }

      


        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();

                      //seeding Branches 
             modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 1, Address = "Riyadh", Area = "Al-Rayan", Name = "Branch-01" });
             modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 2, Address = "Hail", Area = "Al-Nakheel", Name = "Branch-02" });
             modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 3, Address = "AlQassim", Area = "Al-Worood", Name = "Branch-03" });
             modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 4, Address = "AlOla", Area = "Al-Hamra", Name = "Branch-04" });

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 1, FirstName = "Taif", LastName = "Alskeri", Email = "Taif@hotmail.com" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 2, FirstName = "Nora", LastName = "Almutiri", Email = "Nora@hotmail.com" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 3, FirstName = "Maha", LastName = "Alqla", Email = "Maha@hotmail.com" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 4, FirstName = "Ghada", LastName = "Alotibi", Email = "Ghada@hotmail.com" });




        }


    }
}
