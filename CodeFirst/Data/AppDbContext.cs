using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Room>().Property(r => r.RoomType).IsRequired();
            // seedding
            modelBuilder.Entity<Student>().HasData(new Student { Id=1, FirstName="Abdulmajeed", LastName= "Almaymuni", Email= "Abdulmajeed@gmail.com" });
            modelBuilder.Entity<Student>().HasData(new Student { Id=2, FirstName = "Ahmed", LastName = "Almaymuni", Email = "Ahmed@gmail.com" });
            modelBuilder.Entity<Student>().HasData(new Student { Id=3, FirstName = "Abdullah", LastName = "Almaymuni", Email = "Abdullah@gmail.com" });

            modelBuilder.Entity<StudentTeacher>().HasKey(st => new { st.StudentId, st.TeacherId });

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentTeacher> StudentsTeachers { get; set; }
    }
}
