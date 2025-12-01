using System.Text.Json;

namespace Github_User_Activity.Models.Payloads;

public class IssuesEvent(string action, JsonElement issue) : Payload
{
    public string Action { get; init; } = action;
    public JsonElement Issue { get; init; } = issue;
    public override string GetFormattedInto()
    {
        return $"\tAction: {Action}" + "\n" + 
               $"\tIssue: " + FormatJson(Issue) + "\n";
    }
}