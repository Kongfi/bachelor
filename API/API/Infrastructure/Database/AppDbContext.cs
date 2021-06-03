using API.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace API.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public AppDbContext()
        {
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<HorseEntity> Horses { get; set; }

        public override int SaveChanges() => SaveChangesAsync().Result;
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                    e.State == EntityState.Added ||
                    e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                if (entityEntry.State == EntityState.Added)
                    ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.UtcNow;

                ((BaseEntity)entityEntry.Entity).LastModifiedDate = DateTime.UtcNow;
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        // Migrations ved oprettelse af tabeller
        // Override for at indeksere Email
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEntity>()
                .HasIndex(x => x.Email).IsUnique();

            modelBuilder.Entity<HorseEntity>()
                .HasIndex(x => x.FeifID).IsUnique();
        }
    }
}
