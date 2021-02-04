using BRC.Bussiness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TRC.Bussiness.EntitiesConfiguration
{
    public class CustomerEC : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasIndex(b => b.Identification)
                .IsUnique();

            builder.HasIndex(b => b.CreditCard)
                .IsUnique();

            builder.Property(b => b.Id)
                .HasColumnName("CustomerId");

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(b => b.Identification)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(15);

            builder.Property(b => b.CreditCard)
                .IsUnicode(false)
                .HasMaxLength(20);

            builder.Property(b => b.CreditLimit)
                .HasDefaultValue(0);

            builder.Property(b => b.PersonType)
                .IsUnicode(false)
                .HasMaxLength(20)
                .HasDefaultValue("Fisica");

            builder.Property(b => b.Status)
                .HasDefaultValue("A");
        }
    }
}
