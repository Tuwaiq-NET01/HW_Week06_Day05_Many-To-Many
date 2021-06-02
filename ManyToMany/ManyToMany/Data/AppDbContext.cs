using System;
using ManyToMany.Models;
using Microsoft.EntityFrameworkCore;

namespace ManyToMany.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Student>().HasData(new Student { Id = 1 });
            mb.Entity<Teacher>().HasData(new Teacher { Id = 1 });
            mb.Entity<StudentTeacher>().HasData(new StudentTeacher { Id = 1, StudentId = 1, TeacherId = 1 });

            mb.Entity<Customer>().HasData(new Customer { Id = 1 });
            mb.Entity<Product>().HasData(new Product { Id = 1 });
            mb.Entity<CustomerProduct>().HasData(new CustomerProduct { Id = 1, CustomerId = 1, ProductId = 1 });
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentTeacher> Student_Teacher { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomerProduct> Customer_Product { get; set; }
    }
}
