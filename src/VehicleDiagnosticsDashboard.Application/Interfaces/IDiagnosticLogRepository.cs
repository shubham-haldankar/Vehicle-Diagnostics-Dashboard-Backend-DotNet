using VehicleDiagnosticsDashboard.Application.DTOs;
using VehicleDiagnosticsDashboard.Domain.Entities;

namespace VehicleDiagnosticsDashboard.Application.Interfaces
{
    public interface IDiagnosticLogRepository
    {
        Task AddAsync(DiagnosticLog diagnosticLog);

        Task<IReadOnlyList<DiagnosticLog>> FindAsync(DiagnosticLogSearchCriteria filter);
    }
}
