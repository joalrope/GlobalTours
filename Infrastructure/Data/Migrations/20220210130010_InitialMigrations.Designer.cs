﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
  [DbContext(typeof(ApplicationDbContext))]
  [Migration("20220210130010_InitialMigrations")]
  partial class InitialMigrations
  {
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("ProductVersion", "6.0.1")
          .HasAnnotation("Relational:MaxIdentifierLength", 64);

      modelBuilder.Entity("API.Entities.Place", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int");

            b.Property<string>("Name")
                      .HasColumnType("longtext");

            b.HasKey("Id");

            b.ToTable("Place");
          });
#pragma warning restore 612, 618
    }
  }
}
