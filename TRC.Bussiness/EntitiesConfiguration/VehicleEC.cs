using BRC.Bussiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TRC.Bussiness.EntitiesConfiguration
{
    public class VehicleEC : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicle");

            builder.HasOne(p => p.FuelType)
                .WithMany(p => p.Vehicle)
                .HasForeignKey(p => p.FuelTypeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Vehicle_FuelType");

            builder.HasOne(p => p.VehicleModel)
                .WithMany(p => p.Vehicle)
                .HasForeignKey(p => p.VehicleModelId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Vehicle_VehicleModel");

            builder.HasIndex(b => b.NoChassis)
                .IsUnique();

            builder.HasIndex(b => b.NoMotor)
                .IsUnique();

            builder.HasIndex(b => b.NoLicensePlate)
                .IsUnique();

            builder.Property(b => b.Id)
                .HasColumnName("VehicleId");

            builder.Property(b => b.Description)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(b => b.NoChassis)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(20);

            builder.Property(b => b.NoMotor)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(20);

            builder.Property(b => b.NoLicensePlate)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(20);

            builder.Property(b => b.Status)
                .HasDefaultValue("A");
        }
    }
}
