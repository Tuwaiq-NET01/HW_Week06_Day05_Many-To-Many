using System;
using Microsoft.EntityFrameworkCore;
using SchoolMVCef.Models;

namespace SchoolMVCef.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<TeacherModel> Teachers { get; set; }
        public DbSet<TeachModel> Teaches { get; set; }


        //Fluent API 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherModel>().Property(teacher => teacher.Name).IsRequired();


            //seeding (Have this to be run once)

            //modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 1, Name = "RioDan S" });
            //modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 2, Name = "Muhhanad Sami" });
            //modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 3, Name = "Rami Gh" });

            //modelBuilder.Entity<TeacherModel>().HasData(new TeacherModel { Id = 1, Name = "Ali S" });
            //modelBuilder.Entity<TeacherModel>().HasData(new TeacherModel { Id = 2, Name = "Sami W" });
            //modelBuilder.Entity<TeacherModel>().HasData(new TeacherModel { Id = 3, Name = "Y Soul" });


            // composite key comprising both of the foreign key values.
            modelBuilder.Entity<TeachModel>().HasKey(st => new { st.StudentId, st.TeacherId });
            modelBuilder.Entity<TeachModel>()
                .HasOne(st => st.Student)
                .WithMany(t => t.Teach)
                .HasForeignKey(st => st.StudentId);

            modelBuilder.Entity<TeachModel>()
                .HasOne(st => st.Teacher)
                .WithMany(t => t.Teach)
                .HasForeignKey(st => st.TeacherId);

            // re insert data
            //modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 1, Name = "RioDan S" });
            //modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 2, Name = "Muhhanad Sami" });
            //modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 3, Name = "Rami Gh" });

            //modelBuilder.Entity<TeacherModel>().HasData(new TeacherModel { Id = 1, Name = "Ali S" });
            //modelBuilder.Entity<TeacherModel>().HasData(new TeacherModel { Id = 2, Name = "Sami W" });
            //modelBuilder.Entity<TeacherModel>().HasData(new TeacherModel { Id = 3, Name = "Y Soul" });


            modelBuilder.Entity<TeachModel>().HasData(new TeachModel { StudentId = 1, TeacherId = 1 });
            modelBuilder.Entity<TeachModel>().HasData(new TeachModel { StudentId = 2, TeacherId = 1 });
            modelBuilder.Entity<TeachModel>().HasData(new TeachModel { StudentId = 3, TeacherId = 1 });
            modelBuilder.Entity<TeachModel>().HasData(new TeachModel { StudentId = 1, TeacherId = 2 });
            modelBuilder.Entity<TeachModel>().HasData(new TeachModel { StudentId = 2, TeacherId = 2 });
            modelBuilder.Entity<TeachModel>().HasData(new TeachModel { StudentId = 1, TeacherId = 3 });
            modelBuilder.Entity<TeachModel>().HasData(new TeachModel { StudentId = 2, TeacherId = 3 });
            modelBuilder.Entity<TeachModel>().HasData(new TeachModel { StudentId = 3, TeacherId = 3 });
        }
    }
}
