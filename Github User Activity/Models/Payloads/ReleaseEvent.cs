using System.Text.Json;

namespace Github_User_Activity.Models.Payloads;

public class ReleaseEvent(string action, JsonElement release) : Payload
{
    public string Action { get; init; } = action;
    public JsonElement Release { get; init; } = release;

    public override string GetFormattedInto()
    {
        return $"\tAction: {Action}\n" +
               "\tRelease: " + FormatJson(Release) + "\n";
    }
}