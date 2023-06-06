﻿// <auto-generated />
using System;
using AngularAuthAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AngularAuthAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230606055733_V1")]
    partial class V1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AngularAuthAPI.Models.Chatinteraction", b =>
                {
                    b.Property<int>("Cinteraction_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cinteraction_Id"));

                    b.Property<string>("Date_time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Massage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Cinteraction_Id");

                    b.HasIndex("Id");

                    b.ToTable("Chatinteractions");
                });

            modelBuilder.Entity("AngularAuthAPI.Models.Legalinfo", b =>
                {
                    b.Property<int>("Legalinfo_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Legalinfo_Id"));

                    b.Property<string>("Dateadded")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Document")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("Rbook_Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Legalinfo_Id");

                    b.HasIndex("Id");

                    b.ToTable("Legalinfo");
                });

            modelBuilder.Entity("AngularAuthAPI.Models.RBook", b =>
                {
                    b.Property<int>("RBook_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RBook_Id"));

                    b.Property<string>("Creation_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Last_Modified")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("RBook_Id");

                    b.HasIndex("Id");

                    b.ToTable("RBooks");
                });

            modelBuilder.Entity("AngularAuthAPI.Models.SearchQuery", b =>
                {
                    b.Property<int>("SQuery_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SQuery_Id"));

                    b.Property<string>("Date_time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Keywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("SQuery_Id");

                    b.HasIndex("Id");

                    b.ToTable("SearchQuery");
                });

            modelBuilder.Entity("AngularAuthAPI.Models.Users", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_Id"));

                    b.Property<int>("Contact")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organisation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AngularAuthAPI.Models.Chatinteraction", b =>
                {
                    b.HasOne("AngularAuthAPI.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("AngularAuthAPI.Models.Legalinfo", b =>
                {
                    b.HasOne("AngularAuthAPI.Models.RBook", "RBook")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.Navigation("RBook");
                });

            modelBuilder.Entity("AngularAuthAPI.Models.RBook", b =>
                {
                    b.HasOne("AngularAuthAPI.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("AngularAuthAPI.Models.SearchQuery", b =>
                {
                    b.HasOne("AngularAuthAPI.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
