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
        public AppDbContext( DbContextOptions options) : base(options)
        {

        }

        public DbSet<ProductModel> Products { get; set; }
        public  DbSet<CustomerModel> Customers { get; set; }
        public DbSet<BranchModel> Branches { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<OrderModel> Orders { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();

            //seeding
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel {ID=1,Area="Riyadh",Email="saud.alshammari@tuwaiq.edu.sa",Name="Saud" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel {ID=2,Area="Riyadh",Email="saud.alshammari@tuwaiq.edu.sa",Name="Saud" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel {ID=3,Area="Riyadh",Email="saud.alshammari@tuwaiq.edu.sa",Name="Saud" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel {ID=4,Area="Riyadh",Email="saud.alshammari@tuwaiq.edu.sa",Name="Saud" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel {ID=5,Area="Dammam",Email="saud.alshammari@tuwaiq.edu.sa",Name="Saud" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel {ID=6,Area="Dammam",Email="saud.alshammari@tuwaiq.edu.sa",Name="Saud" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel {ID=7,Area="Hafr-Albatin",Email="saud.alshammari@tuwaiq.edu.sa",Name="Saud" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel {ID=8,Area="Jeddah",Email="saud.alshammari@tuwaiq.edu.sa",Name="Saud" });

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { ID = 1,FirstName="Fahad" ,LastName="Anas",Email = "saud.alshammari@tuwaiq.edu.sa"});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { ID = 2,FirstName="Fahad" ,LastName="Anas",Email = "saud.alshammari@tuwaiq.edu.sa"});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { ID = 3,FirstName="Fahad" ,LastName="Anas",Email = "saud.alshammari@tuwaiq.edu.sa"});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { ID = 4,FirstName="Fahad" ,LastName="Anas",Email = "saud.alshammari@tuwaiq.edu.sa"});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { ID = 5,FirstName="Fahad" ,LastName="Anas",Email = "saud.alshammari@tuwaiq.edu.sa"});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { ID = 6,FirstName="Fahad" ,LastName="Anas",Email = "saud.alshammari@tuwaiq.edu.sa"});


            modelBuilder.Entity<Product_Order>()
            .HasKey(t => new { t.ProductId, t.OrderId });

            modelBuilder.Entity<Product_Order>()
                .HasOne(pt => pt.Product)
                .WithMany(p => p.Product_Orders)
                .HasForeignKey(pt => pt.ProductId);

            modelBuilder.Entity<Product_Order>()
                .HasOne(pt => pt.Order)
                .WithMany(t => t.Product_Orders)
                .HasForeignKey(pt => pt.OrderId);


        }
    }
}
