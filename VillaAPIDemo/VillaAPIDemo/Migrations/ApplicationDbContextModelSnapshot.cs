﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VillaApi.Data;

#nullable disable

namespace VillaAPIDemo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VillaAPIDemo.Models.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocalUsers");
                });

            modelBuilder.Entity("VillaApi.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "qwertyu",
                            CreatedDate = new DateTime(2023, 5, 3, 12, 40, 7, 977, DateTimeKind.Local).AddTicks(9929),
                            Details = "awsedrtfuikolkmj dxujhsgfgvbhkm rdgyuhijogf",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                            Name = "abc Villa",
                            Occupancy = 7,
                            Rate = 2000.0,
                            Sqft = 1000,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "oiuyt",
                            CreatedDate = new DateTime(2023, 5, 3, 12, 40, 7, 977, DateTimeKind.Local).AddTicks(9948),
                            Details = "sedrftgyhuj oiujytdrf poiuytrsdcfgvhbjnmk ftgyuhj",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                            Name = "def Villa",
                            Occupancy = 9,
                            Rate = 1500.0,
                            Sqft = 2500,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "fghkj",
                            CreatedDate = new DateTime(2023, 5, 3, 12, 40, 7, 977, DateTimeKind.Local).AddTicks(9951),
                            Details = "wertyuhj lkjhgfd poiuytrdsx kjhgfd",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",
                            Name = "qwe Villa",
                            Occupancy = 3,
                            Rate = 400.0,
                            Sqft = 700,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "dfgjhgjh",
                            CreatedDate = new DateTime(2023, 5, 3, 12, 40, 7, 977, DateTimeKind.Local).AddTicks(9954),
                            Details = "sdfgkjhgfd iuytrdf sdfyujk lokjhgfd",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",
                            Name = "poi Villa",
                            Occupancy = 4,
                            Rate = 500.0,
                            Sqft = 800,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "ertyui",
                            CreatedDate = new DateTime(2023, 5, 3, 12, 40, 7, 977, DateTimeKind.Local).AddTicks(9956),
                            Details = "qwertyuiolkj sdfghjkl lkiuytredxcvbnm sdfghjkkkmnbvcd",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                            Name = "mnb Villa",
                            Occupancy = 5,
                            Rate = 800.0,
                            Sqft = 1200,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("VillaApi.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaId");

                    b.ToTable("VillaNumbers");
                });

            modelBuilder.Entity("VillaApi.Models.VillaNumber", b =>
                {
                    b.HasOne("VillaApi.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
