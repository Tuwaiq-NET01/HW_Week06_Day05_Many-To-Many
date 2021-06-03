﻿// <auto-generated />
using System;
using CodeFirstApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210603024518_AddMany-To-ManyRelationShip")]
    partial class AddManyToManyRelationShip
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirstApp.Models.BranchModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasColumnType("text");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Adress = "Riydh",
                            Area = "alnakuli",
                            Name = "Branche01"
                        },
                        new
                        {
                            id = 2,
                            Adress = "Jeedah",
                            Area = "alnakuli",
                            Name = "Branche02"
                        },
                        new
                        {
                            id = 3,
                            Adress = "makkah",
                            Area = "alnakuli",
                            Name = "Branche03"
                        },
                        new
                        {
                            id = 4,
                            Adress = "madinah",
                            Area = "alnakuli",
                            Name = "Branche04"
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.Custome_ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Customer_Product");
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
                            Email = "@afraa",
                            FirstName = "afra",
                            LastName = "allahyani"
                        },
                        new
                        {
                            Id = 2,
                            Email = "@sara",
                            FirstName = "sara",
                            LastName = "sara"
                        },
                        new
                        {
                            Id = 3,
                            Email = "@nora",
                            FirstName = "nora",
                            LastName = "nora"
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BrancheId")
                        .HasColumnType("int");

                    b.Property<int?>("Branchid")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Branchid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CodeFirstApp.Models.ProfileModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("CodeFirstApp.Models.Custome_ProductModel", b =>
                {
                    b.HasOne("CodeFirstApp.Models.CustomerModel", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstApp.Models.CustomerModel", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirstApp.Models.ProductModel", b =>
                {
                    b.HasOne("CodeFirstApp.Models.BranchModel", "Branch")
                        .WithMany("Products")
                        .HasForeignKey("Branchid");
                });

            modelBuilder.Entity("CodeFirstApp.Models.ProfileModel", b =>
                {
                    b.HasOne("CodeFirstApp.Models.CustomerModel", "Customer")
                        .WithOne("Profile")
                        .HasForeignKey("CodeFirstApp.Models.ProfileModel", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
