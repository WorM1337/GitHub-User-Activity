using System.Text.Json;

namespace Github_User_Activity.Models.Payloads;

public class IssueCommentEvent(string action, JsonElement issue, JsonElement comment) : Payload
{
    public string Action { get; init; } = action;
    public JsonElement Issue { get; init; } = issue;
    public JsonElement Comment { get; init; } = comment;

    public override string GetFormattedInto()
    {
        return $"\tAction: {Action}\n" +
               $"\tIssue: {FormatJson(Issue)}\n" +
               $"\tComment: {FormatJson(Comment)}\n";
    }
}