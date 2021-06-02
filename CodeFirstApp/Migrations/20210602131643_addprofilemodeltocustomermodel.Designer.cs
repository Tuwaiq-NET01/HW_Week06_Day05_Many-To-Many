﻿// <auto-generated />
using CodeFirstApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210602131643_addprofilemodeltocustomermodel")]
    partial class addprofilemodeltocustomermodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirstApp.Models.BranchModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Branchs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "a@a.com",
                            Name = "Anas",
                            address = "Riyadh"
                        },
                        new
                        {
                            Id = 2,
                            Email = "b@b.com",
                            Name = "Saud",
                            address = "Riyadh"
                        },
                        new
                        {
                            Id = 3,
                            Email = "c@c.com",
                            Name = "Hassan",
                            address = "Jeddah"
                        },
                        new
                        {
                            Id = 4,
                            Email = "t@t.com",
                            Name = "AAJ",
                            address = "Dammam"
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "a@a.com",
                            FirstName = "Anas",
                            LastName = "Alhmoud"
                        },
                        new
                        {
                            Id = 2,
                            Email = "b@b.com",
                            FirstName = "Saud",
                            LastName = "Alshammeri"
                        },
                        new
                        {
                            Id = 3,
                            Email = "c@c.com",
                            FirstName = "hssan",
                            LastName = "alghadah"
                        },
                        new
                        {
                            Id = 4,
                            Email = "t@t.com",
                            FirstName = "Abdulalrhman",
                            LastName = "Aljafar"
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.ProductModel", b =>
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
