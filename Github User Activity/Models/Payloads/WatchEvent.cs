namespace Github_User_Activity.Models.Payloads;

public class WatchEvent(string action) : Payload
{
    public string Action { get; init; } = action;

    public override string GetFormattedInto()
    {
        return $"\tAction: {Action}\n";
    }
}