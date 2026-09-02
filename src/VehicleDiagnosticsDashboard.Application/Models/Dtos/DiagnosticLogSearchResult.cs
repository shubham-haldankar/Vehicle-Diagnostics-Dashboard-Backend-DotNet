namespace VehicleDiagnosticsDashboard.Application.Models.Dtos;

public class DiagnosticLogSearchResultDto
{
    public SortField SortedBy { get; set; }

    public string SortedOrder { get; set; } = "desc";

    public int Limit { get; set; }

    public int Offset { get; set; }

    public IReadOnlyList<LogEntry> Records { get; set; } = Array.Empty<LogEntry>();

    public LogsStats Stats { get; set; } = new();
}