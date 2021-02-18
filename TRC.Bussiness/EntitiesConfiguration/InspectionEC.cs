using BRC.Bussiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TRC.Bussiness.EntitiesConfiguration
{
    public class InspectionEC : IEntityTypeConfiguration<Inspection>
    {
        public void Configure(EntityTypeBuilder<Inspection> builder)
        {
            builder.ToTable("Inspection");

            builder.HasOne(p => p.RentDetail)
                .WithMany(p => p.Inspection)
                .HasForeignKey(p => p.RentDetailId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_RentDetail_Inspection");

            builder.Property(b => b.Id)
                .HasColumnName("InspectionId");

            builder.Property(b => b.IsGrated)
                .IsRequired();

            builder.Property(b => b.FuelQuantity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(b => b.IsGrated)
                .IsRequired();

            builder.Property(b => b.HasHydraulicCat)
                .IsRequired();

            builder.Property(b => b.HasSpareTire)
                .IsRequired();

            builder.Property(b => b.HasBrokenMirror)
                .IsRequired();

            builder.Property(b => b.Date)
                .IsRequired()
                .HasColumnType("date")
                .HasDefaultValueSql("getdate()");

            builder.Property(b => b.Status)
                .HasDefaultValue("A");
        }
    }
}
