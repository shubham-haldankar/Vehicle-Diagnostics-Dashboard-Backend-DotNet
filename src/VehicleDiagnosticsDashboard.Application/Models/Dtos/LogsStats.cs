namespace VehicleDiagnosticsDashboard.Application.Models.Dtos;

public class LogsStats
{
    public int Total { get; set; }

    public int Errors { get; set; }

    public int Warns { get; set; }

    public int Infos { get; set; }

    public int Vehicles { get; set; }

    public int Codes { get; set; }
}
