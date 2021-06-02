﻿// <auto-generated />
using CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirst.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210602085755_AddRelationShipsRoomToStudent")]
    partial class AddRelationShipsRoomToStudent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirst.Models.RoomModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Empty")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentID")
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
                            Email = "aalhaif@hotmail.com",
                            FirstName = "Abdullah",
                            LastName = "AL Haif"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Ezz@gmail.com",
                            FirstName = "AbdulAziz",
                            LastName = "Almohammadi"
                        },
                        new
                        {
                            Id = 3,
                            Email = "s.nasser@hotmail.com",
                            FirstName = "Sarah",
                            LastName = "AlNasser"
                        });
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

            modelBuilder.Entity("CodeFirst.Models.RoomModel", b =>
                {
                    b.HasOne("CodeFirst.Models.Student", "Student")
                        .WithOne("Room")
                        .HasForeignKey("CodeFirst.Models.RoomModel", "StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
