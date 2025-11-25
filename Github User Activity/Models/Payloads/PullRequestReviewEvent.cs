namespace Github_User_Activity.Models.Payloads;

public class PullRequestReviewEvent(string Action) : Payload
{
    public string Action { get; init; } = Action;

    public void Deconstruct(out string Action)
    {
        Action = this.Action;
    }
}
// TODO: pull_request, review