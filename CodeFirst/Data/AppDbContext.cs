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
        public  AppDbContext(DbContextOptions<AppDbContext>options): base(options)
        {
        }

        //Fluent API
        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<student_teacher>()
                .HasOne(a => a.Student)
                .WithMany(ab => ab.student_teacher)
                .HasForeignKey(bc => bc.StudentId);

            modelBuilder.Entity<student_teacher>()
                .HasOne(a => a.Teacher)
                .WithMany(ab => ab.student_teacher)
                .HasForeignKey(bc => bc.TeacherId);
            //  modelBuilder.Entity<Room>().Property(r => r.RoomType).IsRequired();
            //seedding
            /*      modelBuilder.Entity<Student>().HasData(new Student { Id = 1, FirstName = "Amal", LastName = "Almutairi", Email = "Amal@gmail.com" });
                  modelBuilder.Entity<Student>().HasData(new Student { Id = 2, FirstName = "Lama", LastName = "Al", Email = "Lama@gmail.com" });
                  modelBuilder.Entity<Student>().HasData(new Student { Id = 3, FirstName = "Reema", LastName = "Al", Email = "Nora@gmail.com" });*/

        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<student_teacher> student_teacher { get; set; }

    }
}
