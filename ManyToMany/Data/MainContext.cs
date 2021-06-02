using ManyToMany.Models;
using Microsoft.EntityFrameworkCore;

namespace ManyToMany.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StudentTeacher>()
                .HasOne(st => st.Student)
                .WithMany(students => students.StudentTeachers)
                .HasForeignKey(st => st.StudentId);
            
            builder.Entity<StudentTeacher>()
                .HasOne(st => st.Teacher)
                .WithMany(teacher => teacher.TeacherStudents)
                .HasForeignKey(st => st.TeacherId);
        }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentTeacher> StudentsTeachers { get; set; }
    }
}