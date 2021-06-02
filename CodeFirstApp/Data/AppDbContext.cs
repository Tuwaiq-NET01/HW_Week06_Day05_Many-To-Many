using CodeFirstApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<BranchModel> Branches { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(p => p.Area).IsRequired();
            //modelBuilder.Entity<BranchModel>().HasData(
            //    new BranchModel { Id = 1, Address = "Riyadh", Area = "Alolaya", Name = "BRanch01" }
            //    , new BranchModel { Id = 2, Address = "Riyadh", Area = "Alolaya", Name = "BRanch02" }
            //    , new BranchModel { Id = 3, Address = "Riyadh", Area = "Alolaya", Name = "BRanch03" }
            //    , new BranchModel { Id = 4, Address = "Riyadh", Area = "Alolaya", Name = "BRanch04" }
            //);
            
            modelBuilder.Entity<CustomerModel>().HasData(
                new CustomerModel {  Id = 1, FirstName = "Riyadh", LastName = "Alolaya", Email = "BRanch01" }
                , new CustomerModel { Id = 2, FirstName  = "Riyadh", LastName = "Alolaya", Email = "BRanch02" }
                , new CustomerModel { Id = 3, FirstName = "Riyadh", LastName = "Alolaya", Email = "BRanch03" }
                , new CustomerModel { Id = 4, FirstName = "Riyadh", LastName = "Alolaya", Email = "BRanch04" }
            );

            // relationship many-to-many
            modelBuilder.Entity<CustomerProductModel>()
                .HasKey(cp => new { cp.CustomerId, cp.ProductId });
                
            modelBuilder.Entity<CustomerProductModel>()
                .HasOne(cp => cp.Customer)
                .WithMany(c => c.CustomerProducts)
                .HasForeignKey(cp => cp.CustomerId);

            modelBuilder.Entity<CustomerProductModel>()
                .HasOne(cp => cp.Product)
                .WithMany(p => p.CustomerProducts)
                .HasForeignKey(cp => cp.ProductId);

        }
    }
}
