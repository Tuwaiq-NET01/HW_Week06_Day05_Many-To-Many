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
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        { 

        }
        //  create  tables
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BranchModel> Branchs { get; set; }
        public DbSet<ProfileModel> profile { get; set; }
        public DbSet<Customers_Products> Customers_Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel 
            { Id = 1, Adress = "Riyadh", Area = "Laban", Name = "Branch01" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
            { Id = 2, Adress = "Riyadh", Area = "Laban", Name = "Branch02" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
            { Id = 3, Adress = "Riyadh", Area = "Laban", Name = "Branch03" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
            { Id = 4, Adress = "Riyadh", Area = "Laban", Name = "Branch04" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
            { Id = 5, Adress = "Riyadh", Area = "Laban", Name = "Branch05" });
            modelBuilder.Entity<Customer>().HasData(new Customer
            { Id = 1, FirstName = "shahad", LastName = "alshehri", Email = "shahad1_cs@hotmail.com", Number = 0503664482 });
            modelBuilder.Entity<Customer>().HasData(new Customer
            { Id = 2, FirstName = "Ali", LastName = "alshehri", Email = "Ali1_cs@hotmail.com", Number = 0553388292 });
        }
    }
}
