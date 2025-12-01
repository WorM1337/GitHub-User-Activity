using System.Text.Json;

namespace Github_User_Activity;

public static class ConfigService
{
    public static JsonSerializerOptions ReadSerializerOptions { get; set; } = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        PropertyNameCaseInsensitive = true
    };public static JsonSerializerOptions FancySerializerOptions { get; set; } = new JsonSerializerOptions
    {
        WriteIndented = true
    };
    
}