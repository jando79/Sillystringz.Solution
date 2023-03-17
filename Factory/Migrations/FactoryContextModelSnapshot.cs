﻿// <auto-generated />
using System;
using Factory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Factory.Migrations
{
    [DbContext(typeof(FactoryContext))]
    partial class FactoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Factory.Models.Engineer", b =>
                {
                    b.Property<int>("EngineerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EngineerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("EngineerId");

                    b.ToTable("Engineers");
                });

            modelBuilder.Entity("Factory.Models.EngineerMachine", b =>
                {
                    b.Property<int>("EngineerMachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EngineerId")
                        .HasColumnType("int");

                    b.Property<int>("MachineId")
                        .HasColumnType("int");

                    b.HasKey("EngineerMachineId");

                    b.HasIndex("EngineerId");

                    b.HasIndex("MachineId");

                    b.ToTable("EngineerMachines");
                });

            modelBuilder.Entity("Factory.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Factory.Models.Machine", b =>
                {
                    b.Property<int>("MachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("EngineerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("MachineName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MachineId");

                    b.HasIndex("EngineerId");

                    b.HasIndex("LocationId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("Factory.Models.MachineLocation", b =>
                {
                    b.Property<int>("MachineLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("MachineId")
                        .HasColumnType("int");

                    b.HasKey("MachineLocationId");

                    b.HasIndex("LocationId");

                    b.HasIndex("MachineId");

                    b.ToTable("MachineLocations");
                });

            modelBuilder.Entity("Factory.Models.EngineerMachine", b =>
                {
                    b.HasOne("Factory.Models.Engineer", "Engineer")
                        .WithMany("JoinEngineer")
                        .HasForeignKey("EngineerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.Models.Machine", "Machine")
                        .WithMany("JoinEngineer")
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Engineer");

                    b.Navigation("Machine");
                });

            modelBuilder.Entity("Factory.Models.Machine", b =>
                {
                    b.HasOne("Factory.Models.Engineer", "Engineer")
                        .WithMany("Machine")
                        .HasForeignKey("EngineerId");

                    b.HasOne("Factory.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Engineer");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Factory.Models.MachineLocation", b =>
                {
                    b.HasOne("Factory.Models.Location", "Location")
                        .WithMany("JoinLocation")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.Models.Machine", "Machine")
                        .WithMany("JoinLocation")
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Machine");
                });

            modelBuilder.Entity("Factory.Models.Engineer", b =>
                {
                    b.Navigation("JoinEngineer");

                    b.Navigation("Machine");
                });

            modelBuilder.Entity("Factory.Models.Location", b =>
                {
                    b.Navigation("JoinLocation");
                });

            modelBuilder.Entity("Factory.Models.Machine", b =>
                {
                    b.Navigation("JoinEngineer");

                    b.Navigation("JoinLocation");
                });
#pragma warning restore 612, 618
        }
    }
}