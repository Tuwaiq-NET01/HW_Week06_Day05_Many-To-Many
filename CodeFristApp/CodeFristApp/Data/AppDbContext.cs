using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFristApp.Models;

namespace CodeFristApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CostomerModel> Costomers { get; set; }
        public DbSet<BranchModel> Branch { get; set; }

        public DbSet<ProfileModel> Profiles { get; set; }


        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();

            modelBuilder.Entity<BranchModel>().HasData( new BranchModel { Id=1,Addres="Riyadh", Name="branch01",Area="------" } );
            modelBuilder.Entity<BranchModel>().HasData( new BranchModel { Id=2,Addres="Jeddah", Name="branch02",Area="------" } );
            modelBuilder.Entity<BranchModel>().HasData( new BranchModel { Id=3,Addres="Qassim", Name="branch03",Area="------" } );
            modelBuilder.Entity<BranchModel>().HasData( new BranchModel { Id=4,Addres="Riyadh", Name="branch04",Area="------" } );
        }
    }
}
