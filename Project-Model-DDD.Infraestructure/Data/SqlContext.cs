using Microsoft.EntityFrameworkCore;
using Project_Model_DDD.Domain.Entities;
using System;
using System.Linq;

namespace Project_Model_DDD.Infraestructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegistrationDate") != null))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Property("RegistrationDate").CurrentValue = DateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Property("RegistrationDate").IsModified = false;
                        break;
                }
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
              .SelectMany(t => t.GetProperties())
              .Where(p => p.ClrType == typeof(string)))
            {
                property.SetColumnType("varchar");
                property.SetMaxLength(100);
            }

            modelBuilder.Entity<Product>(p =>
            {
                p.ToTable("TB_PRODUCT");
                p.HasKey(p => p.Id);               
                p.Property(p => p.Name).IsRequired()
                .HasMaxLength(80);
                p.Property(p => p.BarCode).IsRequired()
                .HasMaxLength(13);
                p.Property(p => p.Price).IsRequired()
                .HasPrecision(10, 2);
            });

            modelBuilder.Entity<Client>(c =>
            {
                c.ToTable("TB_CLIENT");
                c.HasKey(c => c.Id);
                c.Property(c => c.Name).IsRequired();                
                c.Property(c => c.CellNumber)
                .HasMaxLength(14);
            });
                        
            base.OnModelCreating(modelBuilder);
        }
    }
}