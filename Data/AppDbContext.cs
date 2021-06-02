using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public DbSet<CustomerProductModel> CustomerProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<BranchModel>().Property(b => b.Name).IsRequired();
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 1, Address = "jfd", Name = "Meshal", Area = 1 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 2, Address = "jdd", Name = "Mshal", Area = 2 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 3, Address = "jsd", Name = "Mishal", Area = 3 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 4, Address = "jad", Name = "Meishal", Area = 4 });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 1, FirstName = "Mosh", LastName = "Meshal", Email = "Mesh" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 2, FirstName = "Mosh", LastName = "Meshal", Email = "Mesh" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 3, FirstName = "Mosh", LastName = "Meshal", Email = "Mesh" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 4, FirstName = "Mosh", LastName = "Meshal", Email = "Mesh" });
        }
    }
}