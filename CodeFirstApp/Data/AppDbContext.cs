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
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<BranchModel> Branchs { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<CustomerProductModel> CustomersProducts { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(m => m.Email).IsRequired();
            
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 1, address = "Riyadh", Name = "Anas", Email = "a@a.com" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 2, address = "Riyadh", Name = "Saud", Email = "b@b.com" });

            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 3, address = "Jeddah", Name = "Hassan", Email = "c@c.com" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 4, address = "Dammam", Name = "AAJ", Email = "t@t.com" });

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 1, FirstName = "Anas", LastName = "Alhmoud", Email = "a@a.com" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 2, FirstName = "Saud", LastName = "Alshammeri", Email = "b@b.com" });

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 3, FirstName = "hssan", LastName = "alghadah", Email = "c@c.com" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 4, FirstName = "Abdulalrhman", LastName = "Aljafar", Email = "t@t.com" });

        }


    }
}
