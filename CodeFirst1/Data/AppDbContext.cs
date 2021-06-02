using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirst1.Models;

namespace CodeFirst1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)  {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher_Student>()
                .HasOne(s => s.Student)
                .WithMany(element => element.students_teachers)
                .HasForeignKey(item => item.StudentId);

            modelBuilder.Entity<Teacher_Student>()
                .HasOne(s => s.Teacher)
                .WithMany(element => element.students_teachers)
                .HasForeignKey(item => item.TeacherId);
        

        }

        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {*/

        /* modelBuilder.Entity<Student>().Property(r => r.FirstName).IsRequired();
         // sedding use to insert 
         modelBuilder.Entity<Student>().HasData(new Student
         {
             Id = 1,
             FirstName = "Fatma",
             LastName = "Alqhtnay",
             Email = "Fatma@hotmail.com"
         });
         modelBuilder.Entity<Student>().HasData(new Student
         {
             Id = 2,
             FirstName = "Housh",
             LastName = "Alqhtnay",
             Email = "Housh@hotmail.com"
         });
         modelBuilder.Entity<Student>().HasData(new Student
         {
             Id = 3,
             FirstName = "Abdulaziz",
             LastName = "Alqhtnay",
             Email = "Abdulaziz@hotmail.com"
         } );
                }

*/



        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Subject> subject { get; set; }
        public DbSet<Teacher_Student> Teachers_Students { get; set; }

    }


}
