﻿// <auto-generated />
using CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirst.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210601134254_DeleteColumnsInCustomers")]
    partial class DeleteColumnsInCustomers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirst.Models.BranchModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Riyadh",
                            Area = "PNU",
                            Name = "Branch01"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Riyadh",
                            Area = "South",
                            Name = "Branch02"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Riyadh",
                            Area = "North",
                            Name = "Branch03"
                        });
                });

            modelBuilder.Entity("CodeFirst.Models.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CodeFirst.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
