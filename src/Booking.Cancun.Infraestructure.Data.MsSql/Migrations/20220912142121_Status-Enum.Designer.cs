﻿// <auto-generated />
using System;
using Booking.Cancun.Infraestructure.Data.MsSql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Booking.Cancun.Infraestructure.Data.MsSql.Migrations
{
    [DbContext(typeof(BookingContext))]
    [Migration("20220912142121_Status-Enum")]
    partial class StatusEnum
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Booking.Cancun.Infraestructure.Data.MsSql.Entities.BookingOrderDb", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BookedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookingOrders", (string)null);
                });

            modelBuilder.Entity("Booking.Cancun.Infraestructure.Data.MsSql.Entities.BookingOrderStayDb", b =>
                {
                    b.Property<Guid>("BookingOrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Day")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingOrderId", "Day");

                    b.ToTable("BookingOrderStays", (string)null);
                });

            modelBuilder.Entity("Booking.Cancun.Infraestructure.Data.MsSql.Entities.BookingOrderStayDb", b =>
                {
                    b.HasOne("Booking.Cancun.Infraestructure.Data.MsSql.Entities.BookingOrderDb", "BookingOrder")
                        .WithMany("Stays")
                        .HasForeignKey("BookingOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingOrder");
                });

            modelBuilder.Entity("Booking.Cancun.Infraestructure.Data.MsSql.Entities.BookingOrderDb", b =>
                {
                    b.Navigation("Stays");
                });
#pragma warning restore 612, 618
        }
    }
}
