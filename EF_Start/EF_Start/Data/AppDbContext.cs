using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Start.Models;

namespace EF_Start.Data
{
    
    public class AppDbContext : DbContext
    {
        // connection with database
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
        
        
        }

        // creat table
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<BranchModels> Branchs { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<CustomerProductModel> CustomerProduct { get; set; }
        

        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModels>().Property(b => b.Area).IsRequired();
            modelBuilder.Entity<BranchModels>().HasData(new BranchModels{ Id=1, Address="riyadh",Area="Alnakul", Name="Branch01" });
            modelBuilder.Entity<BranchModels>().HasData(new BranchModels { Id = 2, Address = "riyadh", Area = "Alnakul", Name = "Branch02" });
            modelBuilder.Entity<BranchModels>().HasData(new BranchModels { Id = 3, Address = "riyadh", Area = "Alnakul", Name = "Branch03" });

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 1,  Name = "Hussain" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 2,  Name = "Meshal" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 3,  Name = "Thamer" });
        }
    }
}
