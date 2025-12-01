using System.Text.Json;

namespace Github_User_Activity.Models.Payloads;

public class PullRequestReviewCommentEvent(string action, JsonElement pullRequest, JsonElement comment) : Payload
{
    public string Action { get; init; }  = action;
    public JsonElement PullRequest { get; init; } = pullRequest;
    public JsonElement Comment { get; init; } = comment;

    public override string GetFormattedInto()
    {
        return $"\tAction: {Action}\n" +
               "\tPullRequest: " + FormatJson(PullRequest) + "\n" + 
               "\tComment: " + FormatJson(Comment) + "\n";
    }
}