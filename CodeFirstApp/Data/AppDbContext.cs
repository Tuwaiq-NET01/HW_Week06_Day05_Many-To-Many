using System;
using CodeFirstApp.ManyToMany;
using Microsoft.EntityFrameworkCore;
using CodeFirstApp.Models;

namespace CodeFirstApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomersModel> Customers { get; set; }
        public DbSet<BranchModel> Branches { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<CustomersProducts> CustomersProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomersModel>().HasData(new CustomersModel()
                {Id = 1, FirstName = "ali", LastName = "alqahtani", Email = "a@a.a"});
            modelBuilder.Entity<CustomersModel>().HasData(new CustomersModel()
                {Id = 2, FirstName = "ali", LastName = "alqahtani", Email = "a@a.a"});
            modelBuilder.Entity<CustomersModel>().HasData(new CustomersModel()
                {Id = 3, FirstName = "ali", LastName = "alqahtani", Email = "a@a.a"});
            modelBuilder.Entity<CustomersModel>().HasData(new CustomersModel()
                {Id = 4, FirstName = "ali", LastName = "alqahtani", Email = "a@a.a"});
        }
    }
}