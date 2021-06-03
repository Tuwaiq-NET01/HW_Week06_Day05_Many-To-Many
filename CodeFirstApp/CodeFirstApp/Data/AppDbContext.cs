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
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<BranchModel> Branches { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<CustomerProductModel> Customer_Product { get; set; }

        //Fluent API يعطيك صلاحية على كل تفاصيل الجدول و التعديل عليها 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Entity mean Table
            modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();//ERD 
              // modelBuilder.Entity<BranchModel>().Property(b => b.Area).HasColumnName("Area_Size");
           //
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 1 ,Address="Riyadh",Area="Alnakil",Name="Branch01"}) ;
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 2, Address = "Riyadh", Area = "Alnakil", Name = "Branch01" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 3, Address = "Riyadh", Area = "Alnakil", Name = "Branch01" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 4, Address = "Riyadh", Area = "Alnakil", Name = "Branch01" });

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 1, FirstName = "Sara", LastName = "Alnasser", Email = "Sa@gmail.com" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 2, FirstName = "Mohammed", LastName = "Alnasser", Email = "Moh@gmail.com" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 3, FirstName = "Yousif", LastName = "Alnasser", Email = "Yo@gmail.com" });


        }


    }
}
