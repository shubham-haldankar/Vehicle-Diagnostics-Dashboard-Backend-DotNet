using VehicleDiagnosticsDashboard.Domain.Enums;

namespace VehicleDiagnosticsDashboard.Domain.Entities
{
    public class DiagnosticLog
    {
        private DiagnosticLog()
        {
        }

        public Guid Id { get; private set; }

        public string VehicleId { get; private set; } = null!;

        public DateTime DateTimeCreated { get; private set; }

        public string Code { get; private set; } = null!;

        public LogType LogType { get; private set; }

        public string? Message { get; private set; }

        public static DiagnosticLog Create(
        string vehicleId,
        DateTime dateTimeCreated,
        string code,
        LogType logType,
        string? message)
        {
            if (string.IsNullOrWhiteSpace(vehicleId))
                throw new ArgumentException("Vehicle ID is required.");

            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("Diagnostic code is required.");

            return new DiagnosticLog
            {
                Id = Guid.NewGuid(),
                VehicleId = vehicleId,
                DateTimeCreated = dateTimeCreated,
                Code = code,
                LogType = logType,
                Message = message
            };
        }
    }
}
