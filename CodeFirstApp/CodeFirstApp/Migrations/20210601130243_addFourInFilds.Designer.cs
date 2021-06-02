﻿// <auto-generated />
using CodeFirstApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210601130243_addFourInFilds")]
    partial class addFourInFilds
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

                    b.Property<string>("Adress")
                        .HasColumnType("text");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Branchs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "Riyadh",
                            Area = "Laban",
                            Name = "Branch01"
                        },
                        new
                        {
                            Id = 2,
                            Adress = "Riyadh",
                            Area = "Laban",
                            Name = "Branch02"
                        },
                        new
                        {
                            Id = 3,
                            Adress = "Riyadh",
                            Area = "Laban",
                            Name = "Branch03"
                        },
                        new
                        {
                            Id = 4,
                            Adress = "Riyadh",
                            Area = "Laban",
                            Name = "Branch04"
                        },
                        new
                        {
                            Id = 5,
                            Adress = "Riyadh",
                            Area = "Laban",
                            Name = "Branch05"
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.Customer", b =>
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

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customers");
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

                    b.Property<string>("type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
