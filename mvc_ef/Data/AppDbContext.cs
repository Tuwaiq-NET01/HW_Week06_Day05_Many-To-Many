using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc_ef.Models;
namespace mvc_ef.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
            Console.WriteLine("AppDbContext is called");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            // seedding
            modelBuilder.Entity<Teacher>()
            .Property("Email")
            .IsRequired();

            modelBuilder.Entity<Teacher>().HasData(new Teacher { FullName = "D7000M Sensei", Email = "0x1337@<(cat domain).wat" });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { FullName = "Manea Sensei", Email = "0xl33t@<(cat domain).wat" });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { FullName = "D7000M Sensei", Email = "0x1337@<(cat domain).wat" });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { FullName = "Manea Sensei", Email = "0xl33t@<(cat domain).wat" });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { FullName = "D7000M Sensei", Email = "0x1337@<(cat domain).wat" });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { FullName = "Manea Sensei", Email = "0xl33t@<(cat domain).wat" });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { FullName = "D7000M Sensei", Email = "0x1337@<(cat domain).wat" });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { FullName = "Manea Sensei", Email = "0xl33t@<(cat domain).wat" });
            modelBuilder.Entity<Student>().HasData(new Student { Id=1, Fname = "Abdulaziz", Lname = "Alasmari", Email = "aziz@aziz.aziz" });

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
