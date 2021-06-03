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


        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<BranchModel> Branches { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<CustomerProductModel> Customers_Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();

            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
            { Id = 1, Address = "Riyadh", Name = "RH-321", Area = "idk" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
            { Id = 2, Address = "Jeddah", Name = "dd-321", Area = "idk" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
            { Id = 3, Address = "Dammam", Name = "sa-321", Area = "idk" });
        }



    }
}
