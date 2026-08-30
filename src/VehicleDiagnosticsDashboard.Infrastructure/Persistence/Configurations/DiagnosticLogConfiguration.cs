using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleDiagnosticsDashboard.Domain.Entities;

namespace VehicleDiagnosticsDashboard.Infrastructure.Persistence.Configurations
{
    public class DiagnosticLogConfiguration
    : IEntityTypeConfiguration<DiagnosticLog>
    {
        public void Configure(
            EntityTypeBuilder<DiagnosticLog> builder)
        {
            builder.ToTable("VehicleDiagnosticsLogs");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.VehicleId)
                .HasColumnName("VehicleId")
                .IsRequired();

            builder.Property(x => x.DateTimeCreated)
                .HasColumnName("DateTimeCreated")
                .IsRequired();

            builder.Property(x => x.Code)
                .HasColumnName("Code")
                .IsRequired();

            builder.Property(x => x.LogType)
                .HasColumnName("LogType")
                .HasConversion<int>()
                .IsRequired();

            builder.Property(x => x.Message)
                .HasColumnName("Message");
        }
    }
}
