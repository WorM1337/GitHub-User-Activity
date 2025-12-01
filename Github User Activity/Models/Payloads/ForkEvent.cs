using System.Text.Json;

namespace Github_User_Activity.Models.Payloads;

public class ForkEvent(string action, JsonElement forkee) : Payload
{
    public string Action { get; init; } = action;
    public JsonElement Forkee { get; init; } = forkee;
    public override string GetFormattedInto()
    {
        return $"\tAction: {Action}\n" +
               "\tForkee: " + FormatJson(Forkee) + "\n";
    }
}