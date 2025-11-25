namespace Github_User_Activity.Models.Payloads;

public class PullRequestReviewCommentEvent(string Action) : Payload
{
    public string Action { get; init; } = Action;

    public void Deconstruct(out string Action)
    {
        Action = this.Action;
    }
}
// TODO: pull_request, comment