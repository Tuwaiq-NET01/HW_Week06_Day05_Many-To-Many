using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Models;

namespace CodeFirst.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {
            
        }
        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Room>()
                .Property(r => r.Email)
                .IsRequired();*/
            //seeding
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 1, FirstName = "Amal", LastName = "Fahad", Email = "Amal@Amal" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 2, FirstName = "Leenah", LastName = "Fahad", Email = "Amal@Amal" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 3, FirstName = "Sarah", LastName = "Fahad", Email = "Amal@Amal" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 4, FirstName = "Reem", LastName = "Fahad", Email = "Amal@Amal" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 5, FirstName = "Ali", LastName = "Fahad", Email = "Amal@Amal" });

        }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<TeacherModel> Teachers { get; set; }
        public DbSet<RoomModel> Rooms { get; set; }
    }
}
