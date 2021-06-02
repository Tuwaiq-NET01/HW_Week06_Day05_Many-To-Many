using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().Property(r => r.RoomType).IsRequired();
            
            //seeding
            modelBuilder.Entity<Student>().HasData(new Student
                {Id = 1, FirstName = "Ibra", LastName = "Heem", Email = "ibra@ibra.com"});
            modelBuilder.Entity<Student>().HasData(new Student
                {Id = 2, FirstName = "zezo", LastName = "Bro", Email = "ibra@ibra.com"});
            modelBuilder.Entity<Student>().HasData(new Student
                {Id = 3, FirstName = "Yos", LastName = "Fella", Email = "ibra@ibra.com"});
        }

        public DbSet<Student>Students { get; set; }
        public DbSet<Teacher>Teachers { get; set; }
        public DbSet<Room>Rooms { get; set; }
    }
}