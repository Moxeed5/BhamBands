﻿// <auto-generated />
using System;
using BhamBands.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BhamBands.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BhamBands.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Line1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("BhamBands.Models.Attraction", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("EmbeddedId")
                        .HasColumnType("int");

                    b.Property<string>("locale")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("test")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("EmbeddedId");

                    b.ToTable("Attraction");
                });

            modelBuilder.Entity("BhamBands.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("BhamBands.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("countryCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("BhamBands.Models.Dates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("startId")
                        .HasColumnType("int");

                    b.Property<int>("statusId")
                        .HasColumnType("int");

                    b.Property<string>("timezone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("startId");

                    b.HasIndex("statusId");

                    b.ToTable("Dates");
                });

            modelBuilder.Entity("BhamBands.Models.Embedded", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Embedded");
                });

            modelBuilder.Entity("BhamBands.Models.Event", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("_embeddedId")
                        .HasColumnType("int");

                    b.Property<int>("datesId")
                        .HasColumnType("int");

                    b.Property<string>("locale")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("test")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("_embeddedId");

                    b.HasIndex("datesId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("BhamBands.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Attractionid")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Eventid")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("fallback")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("height")
                        .HasColumnType("int");

                    b.Property<string>("ratio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Attractionid");

                    b.HasIndex("Eventid");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("BhamBands.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("latitude")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("longitude")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("BhamBands.Models.Start", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("dateTBA")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("dateTBD")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("localDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("noSpecificTime")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("timeTBA")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Start");
                });

            modelBuilder.Entity("BhamBands.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("stateCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("State");
                });

            modelBuilder.Entity("BhamBands.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("BhamBands.Models.Venue", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("EmbeddedId")
                        .HasColumnType("int");

                    b.Property<int>("addressId")
                        .HasColumnType("int");

                    b.Property<int>("cityId")
                        .HasColumnType("int");

                    b.Property<int>("countryId")
                        .HasColumnType("int");

                    b.Property<string>("locale")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("locationId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("postalCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("stateId")
                        .HasColumnType("int");

                    b.Property<bool>("test")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("timezone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("EmbeddedId");

                    b.HasIndex("addressId");

                    b.HasIndex("cityId");

                    b.HasIndex("countryId");

                    b.HasIndex("locationId");

                    b.HasIndex("stateId");

                    b.ToTable("Venue");
                });

            modelBuilder.Entity("BhamBands.Models.Attraction", b =>
                {
                    b.HasOne("BhamBands.Models.Embedded", null)
                        .WithMany("attractions")
                        .HasForeignKey("EmbeddedId");
                });

            modelBuilder.Entity("BhamBands.Models.Dates", b =>
                {
                    b.HasOne("BhamBands.Models.Start", "start")
                        .WithMany()
                        .HasForeignKey("startId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BhamBands.Models.Status", "status")
                        .WithMany()
                        .HasForeignKey("statusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("start");

                    b.Navigation("status");
                });

            modelBuilder.Entity("BhamBands.Models.Event", b =>
                {
                    b.HasOne("BhamBands.Models.Embedded", "_embedded")
                        .WithMany("events")
                        .HasForeignKey("_embeddedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BhamBands.Models.Dates", "dates")
                        .WithMany()
                        .HasForeignKey("datesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_embedded");

                    b.Navigation("dates");
                });

            modelBuilder.Entity("BhamBands.Models.Image", b =>
                {
                    b.HasOne("BhamBands.Models.Attraction", null)
                        .WithMany("images")
                        .HasForeignKey("Attractionid");

                    b.HasOne("BhamBands.Models.Event", null)
                        .WithMany("images")
                        .HasForeignKey("Eventid");
                });

            modelBuilder.Entity("BhamBands.Models.Venue", b =>
                {
                    b.HasOne("BhamBands.Models.Embedded", null)
                        .WithMany("venues")
                        .HasForeignKey("EmbeddedId");

                    b.HasOne("BhamBands.Models.Address", "address")
                        .WithMany()
                        .HasForeignKey("addressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BhamBands.Models.City", "city")
                        .WithMany()
                        .HasForeignKey("cityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BhamBands.Models.Country", "country")
                        .WithMany()
                        .HasForeignKey("countryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BhamBands.Models.Location", "location")
                        .WithMany()
                        .HasForeignKey("locationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BhamBands.Models.State", "state")
                        .WithMany()
                        .HasForeignKey("stateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("address");

                    b.Navigation("city");

                    b.Navigation("country");

                    b.Navigation("location");

                    b.Navigation("state");
                });

            modelBuilder.Entity("BhamBands.Models.Attraction", b =>
                {
                    b.Navigation("images");
                });

            modelBuilder.Entity("BhamBands.Models.Embedded", b =>
                {
                    b.Navigation("attractions");

                    b.Navigation("events");

                    b.Navigation("venues");
                });

            modelBuilder.Entity("BhamBands.Models.Event", b =>
                {
                    b.Navigation("images");
                });
#pragma warning restore 612, 618
        }
    }
}
