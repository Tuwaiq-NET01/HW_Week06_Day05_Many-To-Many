using System;
using MVCSQL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// App dbcontext extend Dbcontext
namespace MVCSQL.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        // to creat sql table
        public DbSet<CouponCustomer> CouponCustomer { get; set; }
        public DbSet<CouponModel> Coupons { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<CustomerModel> Customer { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<BranchModel> Branches { get; set; }

        //Fluent API 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(branch => branch.Name).IsRequired();
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 1, Name = "Br1", Address = "Riyadh", Area = 1 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 2, Name = "Br2", Address = "Makkah", Area = 12 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 3, Name = "Br3", Address = "Jeddah", Area = 3 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 4, Name = "Br4", Address = "Dammam", Area = 8 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 5, Name = "Br5", Address = "Riyadh", Area = 9 });
            //modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 1, FirstName = "Nada", LastName = "Majed", Email = "Nada@gmail.com" });
            //modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 2, FirstName = "Nawal", LastName = "Rami", Email = "Nawal@gmail.com" });
            //modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 3, FirstName = "Arwa", LastName = "Hassan", Email = "Arwa@gmail.com" });
            //modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 4, FirstName = "Lamia", LastName = "Naif", Email = "Lamia@gmail.com" });
            //seeding (run this only once put it as comment after you update database with it)
            //modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 1, Name = "Br1", Address = "Riyadh", Area = 1 });
            //modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 2, Name = "Br2", Address = "Makkah", Area = 12 });
            //modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 3, Name = "Br3", Address = "Jeddah", Area = 3 });
            //modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 4, Name = "Br4", Address = "Dammam", Area = 8 });
            //modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 1, Name = "iPhone 12", Color = "Black", Price = 3222.92f });
            //modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 2, Name = "iPhone 11", Color = "Red", Price = 2499f });
            //modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 3, Name = "iPhone 11", Color = "Grey", Price = 2499f });
          

        }
    }
}

//dotnet ef database update
//dotnet ef migrations list
//dotnet ef migrations add Profile
//dotnet ef migrations add RelationBetweenProductBranch
//dotnet ef migrations remove
//dotnet ef migrations add Product dotnet ef migrations add Branch dotnet ef migrations add Customer
//dotnet ef migrations add Coupon

//dotnet ef migrations add Join
