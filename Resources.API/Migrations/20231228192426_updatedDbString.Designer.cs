﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Resources.API.Data;

#nullable disable

namespace Resources.API.Migrations
{
    [DbContext(typeof(ResourcesDbContext))]
    [Migration("20231228192426_updatedDbString")]
    partial class updatedDbString
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Resources.API.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "City just south of Tampa.",
                            Name = "Sarasota"
                        },
                        new
                        {
                            Id = 2,
                            Description = "City just north of Sarasota.",
                            Name = "Tampa"
                        },
                        new
                        {
                            Id = 3,
                            Description = "City just south of Sarasota.",
                            Name = "Venice"
                        });
                });

            modelBuilder.Entity("Resources.API.Entities.PointOfInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PointsOfInterest");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Description = "Restaurant by the Marina Jacks",
                            Name = "Bayfront"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Description = "Very popular white sandy beach.",
                            Name = "Siesta Key"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Description = "Huge indoor playground and learning facility for kids",
                            Name = "Glazors Kids Museum"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            Description = "Very popular beach.",
                            Name = "St. Petes Beach"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 3,
                            Description = "Restaurant right on the Venice beach.",
                            Name = "Sharkys"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 3,
                            Description = "Very popular beach with shark teeth",
                            Name = "Venice Beach"
                        });
                });

            modelBuilder.Entity("Resources.API.Entities.PointOfInterest", b =>
                {
                    b.HasOne("Resources.API.Entities.City", "City")
                        .WithMany("PointsOfInterest")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Resources.API.Entities.City", b =>
                {
                    b.Navigation("PointsOfInterest");
                });
#pragma warning restore 612, 618
        }
    }
}
