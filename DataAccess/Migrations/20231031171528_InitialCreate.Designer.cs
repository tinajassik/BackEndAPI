﻿// <auto-generated />
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(DbContext))]
    [Migration("20231031171528_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Domain.Model.Plant", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("PlantPresetPresetId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PlantId");

                    b.HasIndex("PlantPresetPresetId");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("Domain.Model.PlantPreset", b =>
                {
                    b.Property<int>("PresetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Humidity")
                        .HasColumnType("REAL");

                    b.Property<float>("Moisture")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Temperature")
                        .HasColumnType("REAL");

                    b.Property<float>("UVLight")
                        .HasColumnType("REAL");

                    b.HasKey("PresetId");

                    b.ToTable("Presets");
                });

            modelBuilder.Entity("Domain.Model.Plant", b =>
                {
                    b.HasOne("Domain.Model.PlantPreset", "PlantPreset")
                        .WithMany()
                        .HasForeignKey("PlantPresetPresetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlantPreset");
                });
#pragma warning restore 612, 618
        }
    }
}