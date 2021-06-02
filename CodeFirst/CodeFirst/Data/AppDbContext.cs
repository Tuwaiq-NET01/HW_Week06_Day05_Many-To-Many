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

        //FLuent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .Property(r => r.RoomType)
                .IsRequired();
            // seedding
            modelBuilder.Entity<Student>().HasData(new Student {ID=1, FullName = "Samirah Alhusayni", LastName = "ALhusayni", Email = "NAme@mmm" });
            modelBuilder.Entity<Student>().HasData(new Student { ID = 2, FullName = "Ahmedd Alhusayni", LastName = "ALhusayni", Email = "Nddde@mmm" });

            modelBuilder.Entity<Student>().HasData(new Student { ID = 3, FullName = "Salwa Alhusayni", LastName = "ALhusayni", Email = "rew@mmm" });

        }




        public DbSet<Student> Students { get; set; }
            public DbSet<Teacher> Teachers { get; set; }
            public DbSet<Room> Rooms { get; set; }
            public DbSet<Subject> Subjects { get; set; }

            public DbSet<Students_Teachers> Students_Teachers { get; set; }

    }
}
