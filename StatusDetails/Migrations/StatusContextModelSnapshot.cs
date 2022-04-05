﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StatusDetails.Data;

#nullable disable

namespace StatusDetails.Migrations
{
    [DbContext(typeof(StatusContext))]
    partial class StatusContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StatusDetails.Model.Status", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("appointment_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("arriving_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("con_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("con_loaded")
                        .HasColumnType("bit");

                    b.Property<string>("con_loaded_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("container_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("departure_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("receiver_delivery_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ship_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status_id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Statuss");
                });
#pragma warning restore 612, 618
        }
    }
}