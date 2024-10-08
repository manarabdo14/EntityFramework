﻿// <auto-generated />
using System;
using AssEF01.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssEF01.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240826142817_Assignment02")]
    partial class Assignment02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AssEF01.Entities.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Top_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Top_ID");

                    b.ToTable("Course", (string)null);
                });

            modelBuilder.Entity("AssEF01.Entities.Course_Inst", b =>
                {
                    b.Property<int>("inst_ID")
                        .HasColumnType("int");

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<string>("Evaluate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("inst_ID", "Course_ID");

                    b.HasIndex("Course_ID");

                    b.ToTable("Course_Inst");
                });

            modelBuilder.Entity("AssEF01.Entities.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ins_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("AssEF01.Entities.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double>("Bonus")
                        .HasColumnType("float");

                    b.Property<int>("Dept_ID")
                        .HasColumnType("int");

                    b.Property<double>("HourRate")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("Dept_ID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("AssEF01.Entities.Stud_Course", b =>
                {
                    b.Property<int>("stud_ID")
                        .HasColumnType("int");

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("stud_ID", "Course_ID");

                    b.HasIndex("Course_ID");

                    b.ToTable("Stud_Course");
                });

            modelBuilder.Entity("AssEF01.Entities.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Dep_Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Dep_Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("AssEF01.Entities.Topic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("AssEF01.Entities.Course", b =>
                {
                    b.HasOne("AssEF01.Entities.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("Top_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("AssEF01.Entities.Course_Inst", b =>
                {
                    b.HasOne("AssEF01.Entities.Course", "Course")
                        .WithMany("Course_Insts")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssEF01.Entities.Instructor", "Instructor")
                        .WithMany("Course_Insts")
                        .HasForeignKey("inst_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("AssEF01.Entities.Instructor", b =>
                {
                    b.HasOne("AssEF01.Entities.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("Dept_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("AssEF01.Entities.Stud_Course", b =>
                {
                    b.HasOne("AssEF01.Entities.Course", "Course")
                        .WithMany("Stud_Courses")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssEF01.Entities.Student", "Student")
                        .WithMany("Stud_Courses")
                        .HasForeignKey("stud_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("AssEF01.Entities.Student", b =>
                {
                    b.HasOne("AssEF01.Entities.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("Dep_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("AssEF01.Entities.Course", b =>
                {
                    b.Navigation("Course_Insts");

                    b.Navigation("Stud_Courses");
                });

            modelBuilder.Entity("AssEF01.Entities.Department", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("AssEF01.Entities.Instructor", b =>
                {
                    b.Navigation("Course_Insts");
                });

            modelBuilder.Entity("AssEF01.Entities.Student", b =>
                {
                    b.Navigation("Stud_Courses");
                });

            modelBuilder.Entity("AssEF01.Entities.Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
