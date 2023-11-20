using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Vetero.Application.Common.Interfaces;
using Vetero.Domain.Entities.Api;
using Vetero.Domain.Entities.Rapid;
using Vetero.Domain.Entities.WeatherData;
using Vetero.Persistance.Services;

namespace Vetero.Persistance
{
    public class VeteroDbContext : DbContext, IVeteroDbContext
    {
        public string Schema { get; } = "Vetero";
        public DbSet<WeatherStationData> WeatherStationData { get; set; }
        public DbSet<WeatherTestData> WeatherTestData { get; set; }
        public DbSet<ApiUser> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public VeteroDbContext(DbContextOptions<VeteroDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(Schema);
            // ApplyConfiguration dodaje konfiguracje entitis które rozszerzają IEntityTypeConfiguration //
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<ApiUser>()
               .Property(u => u.Email)
               .IsRequired();

            modelBuilder.Entity<Role>()
                .Property(u => u.Name)
                .IsRequired();

            modelBuilder.SeedData();
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
