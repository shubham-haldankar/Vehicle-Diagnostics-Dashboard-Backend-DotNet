using Microsoft.EntityFrameworkCore;
using VehicleDiagnosticsDashboard.Domain.Entities;

namespace VehicleDiagnosticsDashboard.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<DiagnosticLog> DiagnosticLogs => Set<DiagnosticLog>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }


}
