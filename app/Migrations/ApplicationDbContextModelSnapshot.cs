﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SCJ.Booking.MVC.Data;

namespace SCJ.Booking.MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SCJ.Booking.MVC.Models.BookingHistory", b =>
                {
                    b.Property<string>("SmGovUserGuid")
                        .HasMaxLength(36);

                    b.Property<long>("ContainerId");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("SmGovUserGuid", "ContainerId", "Timestamp");

                    b.ToTable("BookingHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
