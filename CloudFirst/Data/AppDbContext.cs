using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CloudFirst.Models;


namespace CloudFirst.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        //Fluent API
        protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Room>().Property(r => r.RoomType).IsRequired();

            //seeding => adding tgreba
            //HASDate >> insert
            modelBuilder.Entity<Student>().HasData(new Student { Id=1,FirstName = "Abdulrahman", LastName = "Sarawiq", Email = "ControlS@gmail.com" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 2,FirstName = "Mohamad", LastName = "Saraw1rqrfiq", Email = "ControlS@gmail.com" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 3, FirstName = "Ibra", LastName = "asdas", Email = "ControlS@gmail.com" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 4, FirstName = "3zz", LastName = "Sqweqq", Email = "ControlS@gmail.com" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 5, FirstName = "ewreqtgerg", LastName = "sdfagtruye", Email = "ControlS@gmail.com" });
        }
        // we have created a new table inside courses
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentTeacher> StudentTeacher { get; set; }

    }
}
