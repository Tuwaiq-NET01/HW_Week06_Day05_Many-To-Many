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
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<BranchModel> Branches { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<CouponModel> Coupons { get; set; }



        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
           //value.Entity<Name of the model>().Property(b => b.Field name)[The condition you want];
             modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();
            
             modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 1, Address = "Riyadh", Area = "Alnakuli", Name = "branch01" });
             modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 2, Address = "Jeddah", Area = "Huwilat", Name = "branch02" });
             modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 3, Address = "Jubail", Area = "AlFanateer", Name = "branch03" });
             modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 4, Address = "Dammam", Area = "Alnakheel", Name = "branch04" });
             modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 5, Address = "Khobar", Area = "AlDharan", Name = "branch05" });
            
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 1, FirstName = "Yasmin", LastName = "AlGhamdi", Email = "Yasmin@hotmail.com" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 2, FirstName = "Lamya", LastName = "AlGhamdi", Email = "Lamya@hotmail.com" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 3, FirstName = "Layan", LastName = "AlGhamdi", Email = "Layan@hotmail.com" });
        }

    }
}
