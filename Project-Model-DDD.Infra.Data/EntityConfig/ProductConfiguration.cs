using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project_Model_DDD.Domain.Entities;

namespace Project_Model_DDD.Infra.Data.EntityConfig
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("TB_PRODUCT");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(80);

            builder.Property(p => p.BarCode)
            .HasMaxLength(13);

            builder.Property(p => p.Price)
            .IsRequired()
            .HasPrecision(10, 2);

            builder.Property(p => p.Stock)
            .IsRequired();

        }
    }
}