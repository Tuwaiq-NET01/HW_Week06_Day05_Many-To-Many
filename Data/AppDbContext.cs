using EFIntro.Models;
using Microsoft.EntityFrameworkCore;

namespace EFIntro.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {
        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<BranchModel> Branches { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        
        // FLUENT API   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();

            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
                {Id = 1, Address = "Riyadh", Name = "RH-321", Area = "idk"});
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
                {Id = 2, Address = "Jeddah", Name = "JED-453", Area = "idk"});
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
                {Id = 3, Address = "Riyadh", Name = "RH-332", Area = "idk"});
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
                {Id = 4, Address = "Jeddah", Name = "JED-55", Area = "idk"});
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
                {Id = 5, Address = "Riyadh", Name = "RH-55", Area = "idk"});
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
                {Id = 6, Address = "Qassim", Name = "QA-55", Area = "idk"});
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
                {Id = 7, Address = "Median", Name = "MD-55", Area = "idk"});
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
                {Id = 8, Address = "Makkah", Name = "MK-55", Area = "idk"});
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
                {Id = 9, Address = "Riyadh", Name = "RH-55", Area = "idk"});
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
                {Id = 10, Address = "Yunbu", Name = "YU-55", Area = "idk"});

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel()
                {Id = 1, FirstName = "ahmed", LastName = "okdlkio", Email = "efkdl@email.com"});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel()
                {Id = 2, FirstName = "khalid", LastName = "dfsfds", Email = "efkdl@email.com"});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel()
                {Id = 3, FirstName = "sara", LastName = "sadsa", Email = "efkdl@email.com"});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel()
                {Id = 4, FirstName = "nora", LastName = "fwerf", Email = "efkdl@email.com"});
        }
    }
    
}