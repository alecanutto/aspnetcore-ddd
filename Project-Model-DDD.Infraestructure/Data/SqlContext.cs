using Microsoft.EntityFrameworkCore;
using Project_Model_DDD.Domain.Entities;
using System;
using System.Linq;

namespace Project_Model_DDD.Infraestructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

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
    }
}