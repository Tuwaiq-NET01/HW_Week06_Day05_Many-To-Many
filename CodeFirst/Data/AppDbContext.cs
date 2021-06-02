using System;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Models;

namespace CodeFirst.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options)
        {
               
        }
        public DbSet<ProductModel> Products
        {
            get;
            set;
        }
        public DbSet<CustomerModel> Customers
        {
            get;
            set;
        }
        public DbSet<BranchModel> Branches
        {
            get;
            set;
        }
        public DbSet<BranchModel> Profiles
        {
            get;
            set;
        }
        public DbSet<CustomerProductModel> CustomerProduct
        {
            get;
            set;
        }

        //fluentAPi
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();

            //seeding
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 1, Address = "Riyadh", Area = "PNU", Name = "Branch01" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 2, Address = "Riyadh", Area = "South", Name = "Branch02" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 3, Address = "Riyadh", Area = "North", Name = "Branch03" });

            //seeding
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 1, Name = "Ali" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 2, Name = "Hussain" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 3, Name = "Thamer" });

            //many-to-many CustomerProduct
            modelBuilder.Entity<CustomerProductModel>()
                .HasKey(cp => new { cp.CustomerId, cp.ProductId });
            modelBuilder.Entity<CustomerProductModel>()
                .HasOne(cp => cp.Product)
                .WithMany(p => p.CustomerProducts)
                .HasForeignKey(cp => cp.ProductId);
            modelBuilder.Entity<CustomerProductModel>()
                .HasOne(cp => cp.Customer)
                .WithMany(c => c.CustomerProducts)
                .HasForeignKey(cp => cp.CustomerId);
        }
    }
}
