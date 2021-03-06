﻿// <auto-generated />
using ASYNC_InnTDCB.Properties.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASYNC_InnTDCB.Migrations
{
    [DbContext(typeof(ASYNCinnDbContext))]
    [Migration("20200408181050_SeedMore")]
    partial class SeedMore
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASYNC_InnTDCB.Models.Amenities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Coffee Maker"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Full Kitchen"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Sea View"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Sky View"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Backyard"
                        });
                });

            modelBuilder.Entity("ASYNC_InnTDCB.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            City = "Seattle",
                            Name = "SeattleWA Hotel",
                            Phone = "2061234567",
                            State = "Washington",
                            StreetAddress = "123 Seattle St."
                        },
                        new
                        {
                            ID = 2,
                            City = "Denver",
                            Name = "Denver Hotel",
                            Phone = "2062222222",
                            State = "Colorado",
                            StreetAddress = "123 Colorado St."
                        },
                        new
                        {
                            ID = 3,
                            City = "Portland",
                            Name = "Portland Hotel",
                            Phone = "2063333333",
                            State = "Oregon",
                            StreetAddress = "123 Portland St."
                        },
                        new
                        {
                            ID = 4,
                            City = "Kona",
                            Name = "Kona Hotel",
                            Phone = "2064444444",
                            State = "Hawaii",
                            StreetAddress = "123 Kona St."
                        },
                        new
                        {
                            ID = 5,
                            City = "San Diego",
                            Name = "San Diego Hotel",
                            Phone = "2065555555",
                            State = "California",
                            StreetAddress = "123 Diego St."
                        });
                });

            modelBuilder.Entity("ASYNC_InnTDCB.Models.HotelRoom", b =>
                {
                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<bool>("PetFriendly")
                        .HasColumnType("bit");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("HotelID", "RoomNumber");

                    b.HasIndex("RoomID");

                    b.ToTable("HotelRooms");

                    b.HasData(
                        new
                        {
                            HotelID = 1,
                            RoomNumber = 101,
                            PetFriendly = true,
                            Rate = 100m,
                            RoomID = 1
                        },
                        new
                        {
                            HotelID = 2,
                            RoomNumber = 201,
                            PetFriendly = true,
                            Rate = 200m,
                            RoomID = 2
                        },
                        new
                        {
                            HotelID = 3,
                            RoomNumber = 301,
                            PetFriendly = false,
                            Rate = 300m,
                            RoomID = 3
                        });
                });

            modelBuilder.Entity("ASYNC_InnTDCB.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Layout")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Layout = 1,
                            Name = "Teemo"
                        },
                        new
                        {
                            ID = 2,
                            Layout = 2,
                            Name = "Lux"
                        },
                        new
                        {
                            ID = 3,
                            Layout = 1,
                            Name = "Jinx"
                        },
                        new
                        {
                            ID = 4,
                            Layout = 0,
                            Name = "Garen"
                        },
                        new
                        {
                            ID = 5,
                            Layout = 2,
                            Name = "Hecarim"
                        },
                        new
                        {
                            ID = 6,
                            Layout = 0,
                            Name = "Ashe"
                        });
                });

            modelBuilder.Entity("ASYNC_InnTDCB.Models.RoomAmenities", b =>
                {
                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<int>("AmenitiesID")
                        .HasColumnType("int");

                    b.HasKey("RoomID", "AmenitiesID");

                    b.HasIndex("AmenitiesID");

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("ASYNC_InnTDCB.Models.HotelRoom", b =>
                {
                    b.HasOne("ASYNC_InnTDCB.Models.Hotel", "Hotel")
                        .WithMany("HotelRooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASYNC_InnTDCB.Models.Room", "Room")
                        .WithMany("HotelRooms")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASYNC_InnTDCB.Models.RoomAmenities", b =>
                {
                    b.HasOne("ASYNC_InnTDCB.Models.Amenities", "Amenities")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("AmenitiesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASYNC_InnTDCB.Models.Room", "Room")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
