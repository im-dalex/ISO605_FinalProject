using BRC.Bussiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TRC.Bussiness.EntitiesConfiguration
{
    public class RentDetailEC : IEntityTypeConfiguration<RentDetail>
    {
        public void Configure(EntityTypeBuilder<RentDetail> builder)
        {
            builder.ToTable("RentDetail");

            builder.HasOne(p => p.Vehicle)
                .WithMany(p => p.RentDetail)
                .HasForeignKey(p => p.VehicleId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_RentDetail_Vehicle");

            builder.HasOne(p => p.Customer)
                .WithMany(p => p.RentDetail)
                .HasForeignKey(p => p.CustomerId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_RentDetail_Customer");

            builder.HasOne(p => p.Employee)
                .WithMany(p => p.RentDetail)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_RentDetail_Employee");

            builder.Property(b => b.Id)
                .HasColumnName("RentDetailId");

            builder.Property(b => b.RentDate)
                .IsRequired()
                .HasColumnType("date")
                .HasDefaultValueSql("getdate()");

            builder.Property(b => b.PriceByDay)
                .IsRequired()
                .HasColumnType("money");

            builder.Property(b => b.RentDays)
                .IsRequired();

            builder.Property(b => b.Comment)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(b => b.Status)
                .HasDefaultValue("A");
        }
    }
}
