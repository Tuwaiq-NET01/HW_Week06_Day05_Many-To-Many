
using System.Reflection.Emit;
using CodeFirstApp.Models;
using Microsoft.EntityFrameworkCore;
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
        
        
        // Fluent APi 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(b => b.Name).IsRequired();
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel{id = 1 , Address="LA" , Area=23 , Name="Mutaz" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel{id = 2 , Address="SF" , Area=478 , Name="Mansour" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel{id = 3 , Address="LA" , Area=23 , Name="Mutaz" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel{id = 4 , Address="SF" , Area=478 , Name="Mansour" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel{id = 5 , Address="LA" , Area=23 , Name="Mutaz" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel{id = 6 , Address="SF" , Area=478 , Name="Mansour" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel
                {id = 1, FirstName = "Mutaz", LastName = "Alajlan", Email = "Mutaz@yahoo.com"});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel
                {id = 2, FirstName = "Mns", LastName = "saab", Email = "sab@yahoo.com"}); 
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel
                {id = 3, FirstName = "Thamer", LastName = "Mashni", Email = "Thamer@yahoo.com"}); 
        }
    }
}