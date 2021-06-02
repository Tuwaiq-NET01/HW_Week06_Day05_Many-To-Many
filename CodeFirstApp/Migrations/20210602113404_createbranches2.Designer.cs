﻿// <auto-generated />
using CodeFirstApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210602113404_createbranches2")]
    partial class createbranches2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirstApp.Models.Branch", b =>
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
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "riydah",
                            Area = "dkdk",
                            Name = "branch1"
                        },
                        new
                        {
                            Id = 2,
                            Address = "riydah",
                            Area = "dkdk",
                            Name = "branch 2"
                        },
                        new
                        {
                            Id = 3,
                            Address = "riydah",
                            Area = "dkdk",
                            Name = "branch 3"
                        },
                        new
                        {
                            Id = 4,
                            Address = "riydah",
                            Area = "dkdk",
                            Name = "branch 4"
                        },
                        new
                        {
                            Id = 5,
                            Address = "riydah",
                            Area = "dkdk",
                            Name = "branch 5"
                        },
                        new
                        {
                            Id = 6,
                            Address = "riydah",
                            Area = "dkdk",
                            Name = "branch 6"
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("firstName")
                        .HasColumnType("text");

                    b.Property<string>("lasName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            id = 1,
                            email = "branch1",
                            firstName = "riydah",
                            lasName = "dkdk"
                        },
                        new
                        {
                            id = 2,
                            email = "branch1",
                            firstName = "hel",
                            lasName = "dkdwewek"
                        },
                        new
                        {
                            id = 3,
                            email = "branch1",
                            firstName = "ss",
                            lasName = "wewedkdk"
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<float>("price")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
