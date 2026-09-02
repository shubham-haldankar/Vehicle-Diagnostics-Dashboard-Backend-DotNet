using VehicleDiagnosticsDashboard.Domain.Enums;

namespace VehicleDiagnosticsDashboard.Application.Models.Dtos;
public class DiagnosticLogSearchCriteria
{
    public string? VehicleId { get; set; }

    public LogType? LogType { get; set; }

    public string? Code { get; set; }

    public DateTime? From { get; set; }

    public DateTime? To { get; set; }

    public int Limit { get; set; } = 20;

    public int Offset { get; set; } = 0;

    public string? SortBy { get; set; }

    public string? SortOrder { get; set; }
}
