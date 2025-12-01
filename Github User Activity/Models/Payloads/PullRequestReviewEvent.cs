using System.Text.Json;

namespace Github_User_Activity.Models.Payloads;

public class PullRequestReviewEvent(string action, JsonElement pullRequest, JsonElement review) : Payload
{
    public string Action { get; init; } = action;
    public JsonElement PullRequest { get; init; } = pullRequest;
    public JsonElement Review { get; init; } = review;
    public override string GetFormattedInto()
    {
        return $"\tAction: {Action}\n" +
               "\tPullRequest: " + FormatJson(PullRequest) + "\n" + 
               "\tReview: " + FormatJson(Review) + "\n";
    }
}