namespace Github_User_Activity.Models.Payloads;

public class PullRequestEvent(string Action, long Number) : Payload
{
    public string Action { get; init; } = Action;
    public long Number { get; init; } = Number;

    public void Deconstruct(out string Action, out long Number)
    {
        Action = this.Action;
        Number = this.Number;
    }
}
// TODO: pull_request, assignee, assignees, label, labels