using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Models;
namespace CodeFirst.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomModel>().Property(r => r.RoomNumber).IsRequired();
            // seedding
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 1, FirstName = "FAS1", LastName = "Saud", Email = "SA@gmail.com" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 2, FirstName = "FAS2", LastName = "Saud", Email = "SA@gmail.com" });
        }
        public DbSet<StudentModel> Students { set; get; }
        public DbSet<TeacherModel> Teachers { set; get; }
        public DbSet<RoomModel> Rooms { set; get; }
        public DbSet<SubjectModel> Subjects { set; get; }
    }
}
