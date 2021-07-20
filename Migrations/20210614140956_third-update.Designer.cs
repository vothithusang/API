﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace AirLineAPI.Migrations
{
    [DbContext(typeof(AirContext))]
    [Migration("20210614140956_third-update")]
    partial class thirdupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AirLineAPI.Models.Location", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("WebApplication1.Models.Customers", b =>
                {
                    b.Property<string>("Staff_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Staff_ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WebApplication1.Models.DetailTicket", b =>
                {
                    b.Property<string>("Ticket_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Amount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flight_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemainAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ticket_ID");

                    b.ToTable("Detailtickets");
                });

            modelBuilder.Entity("WebApplication1.Models.Flight", b =>
                {
                    b.Property<string>("Flight_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EndDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlightTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plane_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Route_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Flight_ID");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("WebApplication1.Models.FlightRoute", b =>
                {
                    b.Property<string>("Route_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Length")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Width")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Route_ID");

                    b.ToTable("FlightRoutes");
                });

            modelBuilder.Entity("WebApplication1.Models.Notes", b =>
                {
                    b.Property<string>("Note_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CheckMaster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckStation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Staff_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Note_ID");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("WebApplication1.Models.Plane", b =>
                {
                    b.Property<string>("Plane_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FistClassSeats")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaneManufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaneName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaneSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondClassSeats")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Total")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Plane_ID");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("WebApplication1.Models.TicketsSold", b =>
                {
                    b.Property<string>("Ticket_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flight_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberOfSold")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Staff_ID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ticket_ID");

                    b.ToTable("TicketsSolds");
                });
#pragma warning restore 612, 618
        }
    }
}