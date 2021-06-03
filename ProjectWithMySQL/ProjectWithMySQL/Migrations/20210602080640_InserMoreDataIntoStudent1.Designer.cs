﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectWithMySQL.Data;

namespace ProjectWithMySQL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210602080640_InserMoreDataIntoStudent1")]
    partial class InserMoreDataIntoStudent1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjectWithMySQL.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Empty")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("RoomType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("ProjectWithMySQL.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Name = "Anis"
                        },
                        new
                        {
                            id = 2,
                            Name = "Krame"
                        },
                        new
                        {
                            id = 3,
                            Name = "saud"
                        },
                        new
                        {
                            id = 4,
                            Name = "sam"
                        },
                        new
                        {
                            id = 5,
                            Name = "Ghada"
                        });
                });

            modelBuilder.Entity("ProjectWithMySQL.Models.Teacher", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
