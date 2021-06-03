using System;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Models;


namespace CodeFirst.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //Fluent API
        //model builder-> let me communicate with the table(entity)

        




        //create student table in database and map it into my project
        public DbSet<StudentModel> Students { get; set; }

        //create teachers table in DB and map it into my project
        public DbSet<TeacherModel> Teachers { get; set; }

        //create rooms table in DB and map it into my project
        public DbSet<RoomModel> Rooms { get; set; }

        //create subjects table in DB and map it into my project
        public DbSet<SubjectModel> Subjects { get; set; }

        //create MANY TO MANY table in DB and map it into my project
        public DbSet<StudentToTeacherModel> StudentsToTeachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<RoomModel>()
                .Property(r => r.RoomType)
                .IsRequired();

            // seedding

            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 1, FirstName = "Arwa", LastName = "Wan La", Eamil = "arwa@gmail.com" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 2, FirstName = "Reham", LastName = "Alonaizy", Eamil = "reham@gmail.com" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 3, FirstName = "Amal", LastName = "Almutairy", Eamil = "amal@gmail.com" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 4, FirstName = "Abdulaziz", LastName = "almohammady", Eamil = "abulaziz@gmail.com" });

            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 5, FirstName = "Samirah", LastName = "Alhosainy", Eamil = "samirah@gmail.com" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 6, FirstName = "Rawaby", LastName = "Alshodokhy", Eamil = "rawabi@gmail.com" });

            //setting up composite Primary Key
           
        
            modelBuilder.Entity<StudentToTeacherModel>()
                .HasKey(cs => new { cs.StudentId, cs.TeacherId });
        
    }

    }
}
