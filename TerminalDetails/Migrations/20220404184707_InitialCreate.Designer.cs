﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TerminalDetails.Data;

#nullable disable

namespace TerminalDetails.Migrations
{
    [DbContext(typeof(TerminalContext))]
    [Migration("20220404184707_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TerminalDetails.Model.Terminal", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terminal_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terminal_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terminal_location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terminal_logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terminal_mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terminal_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terminal_password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terminal_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("terminal_username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Terminals");
                });
#pragma warning restore 612, 618
        }
    }
}
