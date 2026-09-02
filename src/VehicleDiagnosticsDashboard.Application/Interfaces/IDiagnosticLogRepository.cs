using VehicleDiagnosticsDashboard.Application.Models.Dtos;
using VehicleDiagnosticsDashboard.Domain.Entities;

namespace VehicleDiagnosticsDashboard.Application.Interfaces;
public interface IDiagnosticLogRepository
{
    Task AddAsync(DiagnosticLog diagnosticLog, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<DiagnosticLog>> FindAsync(DiagnosticLogSearchCriteria filter, CancellationToken cancellationToken = default);
}

