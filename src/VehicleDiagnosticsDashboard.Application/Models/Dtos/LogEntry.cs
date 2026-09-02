namespace VehicleDiagnosticsDashboard.Application.Models.Dtos;

public class LogEntry
{
    public DateTime DateTimeCreated { get; set; }

    public string Id { get; set; } = string.Empty; 

    public string VehicleId { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;
}