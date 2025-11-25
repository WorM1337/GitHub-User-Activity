namespace Github_User_Activity.Models.Payloads;

public class IssueCommentEvent(string Action, string Issue, string Comment) : Payload
{
    public string Action { get; init; } = Action;
    public string Issue { get; init; } = Issue;
    public string Comment { get; init; } = Comment;

    public void Deconstruct(out string Action, out string Issue, out string Comment)
    {
        Action = this.Action;
        Issue = this.Issue;
        Comment = this.Comment;
    }
}