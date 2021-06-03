using CodeFirstApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions <AppDbContext> options) :base (options)
        { }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<BranchModel> Branches { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<ProfileModel> Profile { get; set; }
        public DbSet<OrdersModel> Orders { get; set; }
        public DbSet<Order_ProductModel> Order_Product { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(branch => branch.Name).IsRequired();

            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 1, Name = "Br1", Address = "Riyadh", Area = 1 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 2, Name = "Br2", Address = "Makkah", Area = 12 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 3, Name = "Br3", Address = "Jeddah", Area = 3 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 4, Name = "Br4", Address = "Dammam", Area = 8 });

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 1, Name = "sara", Email = "sara@gmail"});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 2, Name = "amal", Email = "amal@gmail"});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 3, Name = "battal", Email = "battal@gmail"});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 4, Name = "fares", Email = "fares@gmail"});

        }

    }
}
