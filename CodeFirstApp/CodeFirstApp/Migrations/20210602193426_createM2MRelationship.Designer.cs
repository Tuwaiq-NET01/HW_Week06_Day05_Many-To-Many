﻿// <auto-generated />
using CodeFirstApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210602193426_createM2MRelationship")]
    partial class createM2MRelationship
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

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("id");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Address = "LA",
                            Area = 23,
                            Name = "Mutaz"
                        },
                        new
                        {
                            id = 2,
                            Address = "SF",
                            Area = 478,
                            Name = "Mansour"
                        },
                        new
                        {
                            id = 3,
                            Address = "LA",
                            Area = 23,
                            Name = "Mutaz"
                        },
                        new
                        {
                            id = 4,
                            Address = "SF",
                            Area = 478,
                            Name = "Mansour"
                        },
                        new
                        {
                            id = 5,
                            Address = "LA",
                            Area = 23,
                            Name = "Mutaz"
                        },
                        new
                        {
                            id = 6,
                            Address = "SF",
                            Area = 478,
                            Name = "Mansour"
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.CustomerModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Email = "Mutaz@yahoo.com",
                            FirstName = "Mutaz",
                            LastName = "Alajlan"
                        },
                        new
                        {
                            id = 2,
                            Email = "sab@yahoo.com",
                            FirstName = "Mns",
                            LastName = "saab"
                        },
                        new
                        {
                            id = 3,
                            Email = "Thamer@yahoo.com",
                            FirstName = "Thamer",
                            LastName = "Mashni"
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.CustomerProductModel", b =>
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

                    b.ToTable("CustomerProductModel");
                });

            modelBuilder.Entity("CodeFirstApp.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BranchID")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BranchID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CodeFirstApp.Models.ProfileModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("ProfileModel");
                });

            modelBuilder.Entity("CodeFirstApp.Models.CustomerProductModel", b =>
                {
                    b.HasOne("CodeFirstApp.Models.CustomerModel", "Customer")
                        .WithMany("CustomerProduct")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstApp.Models.ProductModel", "Product")
                        .WithMany("CustomerProduct")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirstApp.Models.ProductModel", b =>
                {
                    b.HasOne("CodeFirstApp.Models.BranchModel", "Branch")
                        .WithMany("Products")
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
