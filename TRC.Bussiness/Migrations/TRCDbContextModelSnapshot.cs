﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TRC.Bussiness.Context;

namespace TRC.Bussiness.Migrations
{
    [DbContext(typeof(TRCDbContext))]
    partial class TRCDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("BRC.Bussiness.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CustomerId")
                        .UseIdentityColumn();

                    b.Property<string>("CreditCard")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("CreditLimit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PersonType")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasDefaultValue("Fisica");

                    b.Property<string>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("A");

                    b.HasKey("Id");

                    b.HasIndex("CreditCard")
                        .IsUnique()
                        .HasFilter("[CreditCard] IS NOT NULL");

                    b.HasIndex("Identification")
                        .IsUnique();

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeId")
                        .UseIdentityColumn();

                    b.Property<int>("Commission")
                        .HasColumnType("int");

                    b.Property<DateTime>("EntryDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Schedule")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasDefaultValueSql("Matutino");

                    b.Property<string>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("A");

                    b.HasKey("Id");

                    b.HasIndex("Identification")
                        .IsUnique();

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.FuelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FuelTypeId")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FuelType");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.Inspection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("InspectionId")
                        .UseIdentityColumn();

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<double>("FuelQuantity")
                        .HasColumnType("float");

                    b.Property<bool>("HasBrokenMirror")
                        .HasColumnType("bit");

                    b.Property<bool>("HasHydraulicCat")
                        .HasColumnType("bit");

                    b.Property<bool>("HasSpareTire")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGrated")
                        .HasColumnType("bit");

                    b.Property<int>("RentDetailId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("A");

                    b.Property<int?>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("RentDetailId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Inspection");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.RentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RentDetailId")
                        .UseIdentityColumn();

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("PriceByDay")
                        .HasColumnType("money");

                    b.Property<DateTime>("RentDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("RentDays")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("A");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("VehicleId");

                    b.ToTable("RentDetail");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.ReturnDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ReturnDetailId")
                        .UseIdentityColumn();

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int>("RentDetailId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RentDetailId");

                    b.ToTable("ReturnDetail");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VehicleId")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("FuelTypeId")
                        .HasColumnType("int");

                    b.Property<string>("NoChassis")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NoLicensePlate")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NoMotor")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("A");

                    b.Property<int>("VehicleModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("NoChassis")
                        .IsUnique();

                    b.HasIndex("NoLicensePlate")
                        .IsUnique();

                    b.HasIndex("NoMotor")
                        .IsUnique();

                    b.HasIndex("VehicleModelId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.VehicleBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VehicleBrandId")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleBrand");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.VehicleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VehicleModelId")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleBrandId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleBrandId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("VehicleModel");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.VehicleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VehicleTypeId")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleType");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.Inspection", b =>
                {
                    b.HasOne("BRC.Bussiness.Entities.Customer", null)
                        .WithMany("Inspection")
                        .HasForeignKey("CustomerId");

                    b.HasOne("BRC.Bussiness.Entities.Employee", null)
                        .WithMany("Inspection")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("BRC.Bussiness.Entities.RentDetail", "RentDetail")
                        .WithMany("Inspection")
                        .HasForeignKey("RentDetailId")
                        .HasConstraintName("FK_RentDetail_Inspection")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BRC.Bussiness.Entities.Vehicle", null)
                        .WithMany("Inspection")
                        .HasForeignKey("VehicleId");

                    b.Navigation("RentDetail");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.RentDetail", b =>
                {
                    b.HasOne("BRC.Bussiness.Entities.Customer", "Customer")
                        .WithMany("RentDetail")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_RentDetail_Customer")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BRC.Bussiness.Entities.Employee", "Employee")
                        .WithMany("RentDetail")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_RentDetail_Employee")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BRC.Bussiness.Entities.Vehicle", "Vehicle")
                        .WithMany("RentDetail")
                        .HasForeignKey("VehicleId")
                        .HasConstraintName("FK_RentDetail_Vehicle")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.ReturnDetail", b =>
                {
                    b.HasOne("BRC.Bussiness.Entities.RentDetail", "RentDetail")
                        .WithMany()
                        .HasForeignKey("RentDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RentDetail");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.Vehicle", b =>
                {
                    b.HasOne("BRC.Bussiness.Entities.FuelType", "FuelType")
                        .WithMany("Vehicle")
                        .HasForeignKey("FuelTypeId")
                        .HasConstraintName("FK_Vehicle_FuelType")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BRC.Bussiness.Entities.VehicleModel", "VehicleModel")
                        .WithMany("Vehicle")
                        .HasForeignKey("VehicleModelId")
                        .HasConstraintName("FK_Vehicle_VehicleModel")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FuelType");

                    b.Navigation("VehicleModel");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.VehicleModel", b =>
                {
                    b.HasOne("BRC.Bussiness.Entities.VehicleBrand", "VehicleBrand")
                        .WithMany("VehicleModel")
                        .HasForeignKey("VehicleBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BRC.Bussiness.Entities.VehicleType", "VehicleType")
                        .WithMany("VehicleModel")
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleBrand");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.Customer", b =>
                {
                    b.Navigation("Inspection");

                    b.Navigation("RentDetail");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.Employee", b =>
                {
                    b.Navigation("Inspection");

                    b.Navigation("RentDetail");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.FuelType", b =>
                {
                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.RentDetail", b =>
                {
                    b.Navigation("Inspection");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.Vehicle", b =>
                {
                    b.Navigation("Inspection");

                    b.Navigation("RentDetail");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.VehicleBrand", b =>
                {
                    b.Navigation("VehicleModel");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.VehicleModel", b =>
                {
                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("BRC.Bussiness.Entities.VehicleType", b =>
                {
                    b.Navigation("VehicleModel");
                });
#pragma warning restore 612, 618
        }
    }
}
