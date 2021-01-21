using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project_Model_DDD.Domain.Entities;

namespace Project_Model_DDD.Infra.Data.EntityConfig
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("TB_CLIENT");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
            .IsRequired();

            builder.Property(c => c.CellNumber)
            .IsRequired()
            .HasMaxLength(14);

            builder.Property(c => c.Email)
            .IsRequired()
            .HasMaxLength(150);

            builder.Property(c => c.Address)
            .HasMaxLength(200);

            builder.Property(c => c.City)
            .HasMaxLength(60);

            builder.Property(c => c.State)
            .HasMaxLength(20);
        }
    }
}