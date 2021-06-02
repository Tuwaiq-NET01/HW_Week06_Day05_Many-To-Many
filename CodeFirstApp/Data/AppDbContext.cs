using CodeFirstApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }

        public DbSet<CustomerModel> Customers { get; set; }

        public DbSet<BranchModel> Branches { get; set; }

        public DbSet<ProfileModel> Profiles { get; set; }

        
        public DbSet<CustomerProductModel> CustomerProduct { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
                {Id = 1, Address = "Riyadh", Area = "Alrabouh", Name = "Branch-1"});
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
                {Id = 3, Address = "Riyadh", Area = "Alkharj", Name = "Branch-3"});
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
                {Id = 2, Address = "Riyadh", Area = "Alrabouh", Name = "Branch-2"});

            modelBuilder.Entity<CustomerModel>().HasData(
                new CustomerModel {Email = "Example@example.com" , FirstName = "Abdullah" , LastName = "Albagshi" ,Id = 1},
                new CustomerModel {Email = "Example@example.com" , FirstName = "Ahmed" , LastName = "test" ,Id = 2},
                new CustomerModel {Email = "Example@example.com" , FirstName = "Mohammed" , LastName = "Teset" ,Id = 3}
            );
        }
    }
}