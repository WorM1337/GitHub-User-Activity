namespace Github_User_Activity.Models.Payloads;

public class CommitCommentEvent(string action, string comment) : Payload
{
    public string Action { get; init; } = action;
    public string Comment { get; init; } = comment;
}