using BRC.Bussiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TRC.Bussiness.EntitiesConfiguration
{
    public class EmployeeEC : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.HasIndex(b => b.Identification)
                .IsUnique();

            builder.Property(b => b.Id)
                .HasColumnName("EmployeeId");

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(b => b.Identification)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(15);

            builder.Property(b => b.Schedule)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(30);
                //.HasDefaultValueSql("Matutino");

            builder.Property(b => b.Commission)
               .IsRequired();

            builder.Property(b => b.EntryDate)
                .IsRequired()
                .HasColumnType("date")
                .HasDefaultValueSql("getdate()");

            builder.Property(b => b.Status)
                .HasDefaultValue("A");
        }
    }
}
