﻿// <auto-generated />
using CodeFirstApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210602200340_NewOneToManyRelationBetweenBranchAndProduct")]
    partial class NewOneToManyRelationBetweenBranchAndProduct
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
                            Area = "Almansorea",
                            Name = "Mansour"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Dammam",
                            Area = "Mansovic",
                            Name = "BranchA"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Jed",
                            Area = "Jaded",
                            Name = "BranchB"
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
                            Email = "23askda@masd.com",
                            FirstName = "Mansour",
                            LastName = "Ruosnam"
                        },
                        new
                        {
                            Id = 2,
                            Email = "23@me.com",
                            FirstName = "Manso",
                            LastName = "osnaM"
                        },
                        new
                        {
                            Id = 3,
                            Email = "a@a.com",
                            FirstName = "M",
                            LastName = "Man"
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CodeFirstApp.Models.ProfileModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("img")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("CodeFirstApp.Models.ProductModel", b =>
                {
                    b.HasOne("CodeFirstApp.Models.BranchModel", "Branch")
                        .WithMany("Products")
                        .HasForeignKey("BranchId")
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
