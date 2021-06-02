﻿// <auto-generated />
using CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirst.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210602100507_InsertData")]
    partial class InsertData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirst.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Empty")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("CodeFirst.Models.Student", b =>
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

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Amal@gmail.com",
                            FirstName = "Amal",
                            LastName = "Almutairi"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Lama@gmail.com",
                            FirstName = "Lama",
                            LastName = "Al"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Nora@gmail.com",
                            FirstName = "Reema",
                            LastName = "Al"
                        });
                });

            modelBuilder.Entity("CodeFirst.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("CodeFirst.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CodeFirst.Models.Room", b =>
                {
                    b.HasOne("CodeFirst.Models.Student", "Student")
                        .WithOne("Room")
                        .HasForeignKey("CodeFirst.Models.Room", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirst.Models.Subject", b =>
                {
                    b.HasOne("CodeFirst.Models.Teacher", "Teacher")
                        .WithMany("Subject")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
