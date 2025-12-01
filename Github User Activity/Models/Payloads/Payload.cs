using System.Text.Json;

namespace Github_User_Activity.Models.Payloads;

public abstract class Payload
{
    public abstract string GetFormattedInto();

    public string FormatJson(JsonElement element)
    {
        return TabulationFormatter.FormatTextTabulation(JsonSerializer.Serialize(element,
            ConfigService.FancySerializerOptions));
    }
}