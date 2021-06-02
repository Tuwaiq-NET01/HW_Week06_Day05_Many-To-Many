using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Models;

namespace CodeFirst.Data
{
    public class AppDbContext : DbContext
    {
      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //Fluent Api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<roomModel>()
                .Property(r => r.roomType)
                .IsRequired();

            modelBuilder.Entity<roomModel>()
                .Property(r => r.roomType)
                .HasMaxLength(20);

            //seeding

            modelBuilder.Entity<Student>()
                .HasData(new Student
                {id=1, firstName = "Albandry", lastName = "AlQaseemi", email = "BQ@gmail.com" });

            modelBuilder.Entity<Student>()
              .HasData(new Student
              { id = 2, firstName = "Sarah", lastName = "AlQaseemi", email = "SQ@gmail.com" });

            modelBuilder.Entity<Student>()
              .HasData(new Student
              { id = 3, firstName = "Sami", lastName = "Aldahlawi", email = "sami@gmail.com" });

             modelBuilder.Entity<Student>()
              .HasData(new Student
              { id = 4, firstName = "Waleed", lastName = "AlQaseemi", email = "waleed@gmail.com" });

            modelBuilder.Entity<Teacher>()
            .HasData(new Teacher
            { id = 1, firstName = "Sami", lastName = "Aldahlawi", email = "sami@gmail.com" });

            modelBuilder.Entity<Student_teacher>()
              .HasOne(s => s.Student)
              .WithMany(element => element.Student_teacher)
              .HasForeignKey(item => item.StudentId);

            modelBuilder.Entity<Student_teacher>()
                .HasOne(s => s.Teacher)
                .WithMany(element => element.Student_teacher)
                .HasForeignKey(item => item.TeacherId);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<roomModel> Rooms { get; set; }
        public DbSet<Student_teacher> Student_teacher { get; set; }



    }
}
