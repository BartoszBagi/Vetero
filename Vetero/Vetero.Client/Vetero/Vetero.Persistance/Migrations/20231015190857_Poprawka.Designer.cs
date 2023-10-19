﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vetero.Persistance;

#nullable disable

namespace Vetero.Persistance.Migrations
{
    [DbContext(typeof(VeteroDbContext))]
    [Migration("20231015190857_Poprawka")]
    partial class Poprawka
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Vetero")
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Vetero.Domain.Entities.Rapid.WeatherTestData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Humidity")
                        .HasColumnType("float");

                    b.Property<double>("Pressure")
                        .HasColumnType("float");

                    b.Property<double>("Temperature")
                        .HasColumnType("float");

                    b.Property<double>("TotalPrecip_mm")
                        .HasColumnType("float");

                    b.Property<double>("WindKph")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("WeatherTestData", "Vetero");
                });

            modelBuilder.Entity("Vetero.Domain.Entities.WeatherData.WeatherStationData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Humidity")
                        .HasColumnType("float");

                    b.Property<double>("Pressure")
                        .HasColumnType("float");

                    b.Property<double>("Sunrise")
                        .HasColumnType("float");

                    b.Property<double>("Sunset")
                        .HasColumnType("float");

                    b.Property<double>("Temperature")
                        .HasColumnType("float");

                    b.Property<double>("TotalPrecip_in")
                        .HasColumnType("float");

                    b.Property<double>("TotalPrecip_mm")
                        .HasColumnType("float");

                    b.Property<double>("Uv")
                        .HasColumnType("float");

                    b.Property<string>("WindDir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WindKph")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("WeatherStationData", "Vetero");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 10, 15, 4, 20, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 12.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 30.0
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2023, 10, 15, 4, 45, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 13.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2023, 10, 15, 5, 30, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 14.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2023, 10, 15, 6, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 13.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2023, 10, 15, 6, 45, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 14.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 16.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2023, 10, 15, 7, 25, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 45.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 18.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 40.0
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2023, 10, 15, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 45.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 20.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2023, 10, 15, 8, 20, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 40.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 21.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 35.0
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2023, 10, 15, 8, 45, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 21.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2023, 10, 15, 9, 20, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 21.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(2023, 10, 15, 9, 45, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 22.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 13,
                            Date = new DateTime(2023, 10, 15, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 22.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 14,
                            Date = new DateTime(2023, 10, 15, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 23.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 15,
                            Date = new DateTime(2023, 10, 15, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 24.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 16,
                            Date = new DateTime(2023, 10, 15, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 25.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 17,
                            Date = new DateTime(2023, 10, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 25.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 18,
                            Date = new DateTime(2023, 10, 15, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 25.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 19,
                            Date = new DateTime(2023, 10, 15, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 25.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 20,
                            Date = new DateTime(2023, 10, 15, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 25.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 21,
                            Date = new DateTime(2023, 10, 15, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 25.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 22,
                            Date = new DateTime(2023, 10, 15, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 23.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 23,
                            Date = new DateTime(2023, 10, 15, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 21.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 24,
                            Date = new DateTime(2023, 10, 15, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 19.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        },
                        new
                        {
                            Id = 25,
                            Date = new DateTime(2023, 10, 15, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            Humidity = 50.0,
                            Pressure = 1006.0,
                            Sunrise = 6.2999999999999998,
                            Sunset = 22.0,
                            Temperature = 18.0,
                            TotalPrecip_in = 0.0,
                            TotalPrecip_mm = 0.0,
                            Uv = 6.0,
                            WindDir = "East",
                            WindKph = 33.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
