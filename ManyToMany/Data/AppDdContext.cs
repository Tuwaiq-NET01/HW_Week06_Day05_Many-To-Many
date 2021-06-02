using System;
using CodeFirst.Models;
using ManyToMany.Models;
using Microsoft.EntityFrameworkCore;

namespace ManyToMany.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentsTeachers>()
                .HasKey(st => new { st.StudentId, st.TeacherId });
            modelBuilder.Entity<StudentsTeachers>()
                .HasOne(st => st.Student)
                .WithMany(t => t.Teachers)
                .HasForeignKey(t => t.StudentId);
            modelBuilder.Entity<StudentsTeachers>()
                .HasOne(ts => ts.Teacher)
                .WithMany(st => st.Students)
                .HasForeignKey(s => s.TeacherId);
        }
    }
}
