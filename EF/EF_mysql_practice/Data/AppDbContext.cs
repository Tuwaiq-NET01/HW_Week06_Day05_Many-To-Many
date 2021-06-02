using System;
using Microsoft.EntityFrameworkCore;
using EF_mysql_practice.Models;

namespace EF_mysql_practice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<BranchModel> Branches { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }

        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();

            //seeding
            //branch
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel {Id=1,Address="Riyadh",Area="Alnakuli", Name="Branch02" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel {Id=2,Address="Makkah",Area="Alsharia", Name="Branch01" });

            //customer
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel() { Id = 1, Email = "h@g.com", FirstName = "hanan", LastName = "hakami"});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel() { Id = 2, Email = "are@g.com", FirstName = "areej", LastName = "hakami"});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel() { Id = 3, Email = "ary@g.com", FirstName = "aryam", LastName = "hakami"});

        }
    }
}
