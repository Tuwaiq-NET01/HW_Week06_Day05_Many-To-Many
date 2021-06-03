﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectWithMySQL.Data;

namespace ProjectWithMySQL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

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

            modelBuilder.Entity("ProjectWithMySQL.Models.Student_teacher", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Student_teacher");
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

            modelBuilder.Entity("ProjectWithMySQL.Models.Room", b =>
                {
                    b.HasOne("ProjectWithMySQL.Models.Student", "student")
                        .WithOne("room")
                        .HasForeignKey("ProjectWithMySQL.Models.Room", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectWithMySQL.Models.Student_teacher", b =>
                {
                    b.HasOne("ProjectWithMySQL.Models.Student", "student")
                        .WithMany("student_teacher_list")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectWithMySQL.Models.Teacher", "teacher")
                        .WithMany("student_teacher_list")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
