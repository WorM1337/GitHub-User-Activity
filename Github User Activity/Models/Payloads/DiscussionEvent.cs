namespace Github_User_Activity.Models.Payloads;

public class DiscussionEvent(string Action, string Discussion) : Payload
{
    public string Action { get; init; } = Action;
    public string Discussion { get; init; } = Discussion;

    public void Deconstruct(out string Action, out string Discussion)
    {
        Action = this.Action;
        Discussion = this.Discussion;
    }
}