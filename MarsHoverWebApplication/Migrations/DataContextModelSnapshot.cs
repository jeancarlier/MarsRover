﻿// <auto-generated />
using System;
using MarsHoverWebApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarsHoverWebApplication.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MarsHoverWebApplication.Models.Hover", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hovers");
                });

            modelBuilder.Entity("MarsHoverWebApplication.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HeadingTo")
                        .HasColumnType("int");

                    b.Property<int?>("HoverId")
                        .HasColumnType("int");

                    b.Property<string>("MaxGridSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MovimentTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NavigationSteps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HoverId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MarsHoverWebApplication.Models.Location", b =>
                {
                    b.HasOne("MarsHoverWebApplication.Models.Hover", "Hover")
                        .WithMany("Locations")
                        .HasForeignKey("HoverId");

                    b.Navigation("Hover");
                });

            modelBuilder.Entity("MarsHoverWebApplication.Models.Hover", b =>
                {
                    b.Navigation("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
