using System.Text.Json.Serialization;

namespace VehicleDiagnosticsDashboard.Application.Models.Dtos;

public enum SortField
{
    [JsonStringEnumMemberName("dateTimeCreated")]
    DateTimeCreated,

    [JsonStringEnumMemberName("vehicleId")]
    VehicleId,

    [JsonStringEnumMemberName("type")]
    Type,

    [JsonStringEnumMemberName("code")]
    Code
}