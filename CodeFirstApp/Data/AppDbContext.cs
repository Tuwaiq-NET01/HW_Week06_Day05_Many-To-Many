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
        public AppDbContext(DbContextOptions<AppDbContext> options)
                   : base(options)
        {

        }
        //create sql table
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<BranchModel> Branches { get; set; }
        public DbSet<ProfileModel> Profile { get; set; }
        public DbSet<CouponModel> Coupons { get; set; }
        public DbSet<CouponCustomer> CouponCustomer { get; set; }

        //Fluent API 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(branch => branch.Name).IsRequired();

            //seeding (run this only once put it as comment after you update database with it)
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 1, Name = "Br1", Address = "Riyadh", Area = 1 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 2, Name = "Br2", Address = "Makkah", Area = 12 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 3, Name = "Br3", Address = "Jeddah", Area = 3 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 4, Name = "Br4", Address = "Dammam", Area = 8 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 5, Name = "Br5", Address = "Riyadh", Area = 9 });

            modelBuilder.Entity<CouponCustomer>()
                .HasKey(cc => new { cc.CouponId, cc.CustomerId });
            modelBuilder.Entity<CouponCustomer>()
                .HasOne(cc => cc.Coupon)
                .WithMany(b => b.CouponCustomer)
                .HasForeignKey(cc => cc.CouponId);
            modelBuilder.Entity<CouponCustomer>()
                .HasOne(cc => cc.Customer)
                .WithMany(c => c.CouponCustomer)
                .HasForeignKey(cc => cc.CustomerId);

            /*            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 1, FirstName = "Ahmad", LastName = "Ali", Email = "ahmadAli@gmail.com"});
                        modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 2, FirstName = "Hanan", LastName = "Zaid", Email = "HanaZaid@gmail.com" });
                        modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 3, FirstName = "Ranan", LastName = "Qassim", Email = "RanaQa@gmail.com" });
                        modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 4, FirstName = "Jana", LastName = "Muath", Email = "Rana21@gmail.com" });
            */
            /*            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 1, Name = "iPhone 12", Color = "Black", Price = 3222.92f });
                        modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 2, Name = "iPhone 11", Color = "Red", Price = 2499f });
                        modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 3, Name = "iPhone 11", Color = "Grey", Price = 2499f });*/
        }
    }
}
