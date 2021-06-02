﻿// <auto-generated />
using MVC_DB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_DB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210602090740_CreateSubjectContext")]
    partial class CreateSubjectContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MVC_DB.Models.RoomModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("StudnetId")
                        .HasColumnType("int");

                    b.Property<string>("avalibalty")
                        .HasColumnType("text");

                    b.Property<int>("roomNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudnetId")
                        .IsUnique();

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("MVC_DB.Models.StudnetModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("firstName")
                        .HasColumnType("text");

                    b.Property<string>("lastName")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Studnets");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            email = "rawabe44u@gmail.com",
                            firstName = "Rawabe",
                            lastName = "Ebrahim"
                        },
                        new
                        {
                            ID = 2,
                            email = "reema@gmail.com",
                            firstName = "Reema",
                            lastName = "Alyosif"
                        },
                        new
                        {
                            ID = 3,
                            email = "amal@gmail.com",
                            firstName = "Amal",
                            lastName = "Alagel"
                        });
                });

            modelBuilder.Entity("MVC_DB.Models.Subject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("MVC_DB.Models.TeacherModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("fullName")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("MVC_DB.Models.RoomModel", b =>
                {
                    b.HasOne("MVC_DB.Models.StudnetModel", "Studnet")
                        .WithOne("Room")
                        .HasForeignKey("MVC_DB.Models.RoomModel", "StudnetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
