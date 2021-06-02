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
            //seeding
            modelBuilder.Entity<Room>().Property(r => r.RoomType).IsRequired();

            //modelBuilder.Entity<Student>().HasData(new Student {Id = 1, FirstName = "Mohammed", LastName = "Rashed", Email = "moh@example.com" });
            //modelBuilder.Entity<Student>().HasData(new Student {Id = 2, FirstName = "Saad", LastName = "Khalid", Email = "Saad@example.com" });
            //modelBuilder.Entity<Student>().HasData(new Student {Id = 3, FirstName = "Abdullah", LastName = "Ahmed", Email = "Abdul@example.com" });
            //modelBuilder.Entity<Student>().HasData(new Student {Id = 4, FirstName = "Khalid", LastName = "Abdulaziz", Email = "test@example.com" });


            modelBuilder.Entity<StudentTeacher>().HasKey(st => new { st.StudentId, st.TeacherId }); //composite key

            //modelBuilder.Entity<StudentTeacher>()
            //    .HasOne<Student>(s => s.Student)
            //    .WithMany(s => s.StudentTeacher)
            //    .HasForeignKey(st => st.StudentId);


            //modelBuilder.Entity<StudentTeacher>()
            //    .HasOne<Teacher>(t => t.Teacher)
            //    .WithMany(s => s.StudentTeacher)
            //    .HasForeignKey(st => st.TeacherId);
        }



        public DbSet<Student> Students { get; set; } //created table named students.
        public DbSet<Teacher> Teachers { get; set; } //teacher = name of the table.
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentTeacher> StudentTeacher { get; set; }




    }
}
