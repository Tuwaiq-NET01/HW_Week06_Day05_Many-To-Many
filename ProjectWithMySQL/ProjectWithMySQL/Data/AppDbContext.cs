using System;
using Microsoft.EntityFrameworkCore;
using ProjectWithMySQL.Models;
namespace ProjectWithMySQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base (options)
        {
        }
        //Flunent
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Room>().Property(r => r.RoomType).IsRequired();
            modelBuilder.Entity<Student>().HasData(new Student {id=1, Name="Anis"});
            modelBuilder.Entity<Student>().HasData(new Student {id = 2, Name = "Krame" });
            modelBuilder.Entity<Student>().HasData(new Student { id = 3, Name = "saud" });
            modelBuilder.Entity<Student>().HasData(new Student { id = 4, Name = "sam" });
            modelBuilder.Entity<Student>().HasData(new Student { id = 5, Name = "Ghada" });
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Room> Rooms { get; set; }

    }
}
