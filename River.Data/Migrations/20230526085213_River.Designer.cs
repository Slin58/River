﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using River.Data.Models.Repository;

#nullable disable

namespace River.Data.Migrations
{
    [DbContext(typeof(RiverContext))]
    [Migration("20230526085213_River")]
    partial class River
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("River.Data.Models.Domain.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<bool>("Firm")
                        .HasColumnType("bit");

                    b.Property<string>("Offer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Statement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherReference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UniversityID")
                        .HasColumnType("int");

                    b.Property<string>("UniversityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UniversityID");

                    b.HasIndex("UserId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("River.Data.Models.Domain.University", b =>
                {
                    b.Property<int>("UniversityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UniversityID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UniversityID");

                    b.HasIndex("UserId");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("River.Data.Models.Domain.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("River.Data.Models.Domain.Application", b =>
                {
                    b.HasOne("River.Data.Models.Domain.University", null)
                        .WithMany("Applications")
                        .HasForeignKey("UniversityID");

                    b.HasOne("River.Data.Models.Domain.User", null)
                        .WithMany("Applications")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("River.Data.Models.Domain.University", b =>
                {
                    b.HasOne("River.Data.Models.Domain.User", null)
                        .WithMany("Universities")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("River.Data.Models.Domain.University", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("River.Data.Models.Domain.User", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("Universities");
                });
#pragma warning restore 612, 618
        }
    }
}