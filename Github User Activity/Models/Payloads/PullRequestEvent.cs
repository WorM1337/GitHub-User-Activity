using System.Text.Json;

namespace Github_User_Activity.Models.Payloads;

public class PullRequestEvent(string action, long number, JsonElement pullRequest) : Payload
{
    public string Action { get; init; }  = action;
    public long Number { get; init; }  = number;
    public JsonElement PullRequest { get; init; }  =  pullRequest;

    public override string GetFormattedInto()
    {
        return $"\tAction: {Action}" + "\n" +
               $"\tNumber: {Number}" + "\n" +
               $"\tPullRequest: " + FormatJson(PullRequest) + "\n";
    }
}