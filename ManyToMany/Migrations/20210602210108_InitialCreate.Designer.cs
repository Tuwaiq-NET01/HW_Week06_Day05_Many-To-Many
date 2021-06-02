﻿// <auto-generated />
using ManyToMany.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManyToMany.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20210602210108_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("ManyToMany.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ManyToMany.Models.StudentTeacher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("studentsteachers");
                });

            modelBuilder.Entity("ManyToMany.Models.Teacher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ManyToMany.Models.StudentTeacher", b =>
                {
                    b.HasOne("ManyToMany.Models.Student", "Student")
                        .WithMany("StudentTeachers")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManyToMany.Models.Teacher", "Teacher")
                        .WithMany("TeacherStudents")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ManyToMany.Models.Student", b =>
                {
                    b.Navigation("StudentTeachers");
                });

            modelBuilder.Entity("ManyToMany.Models.Teacher", b =>
                {
                    b.Navigation("TeacherStudents");
                });
#pragma warning restore 612, 618
        }
    }
}
