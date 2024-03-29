﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Website.Models;

#nullable disable

namespace S3.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20240209084028_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("Website.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GradeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Section")
                        .HasColumnType("TEXT");

                    b.HasKey("GradeId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("Website.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<int?>("GradeId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Height")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("StudentID");

                    b.HasIndex("GradeId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Website.Models.Student", b =>
                {
                    b.HasOne("Website.Models.Grade", "Grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeId");

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("Website.Models.Grade", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
