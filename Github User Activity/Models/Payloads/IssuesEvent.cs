namespace Github_User_Activity.Models.Payloads;

public class IssuesEvent(string Action, string Issue) : Payload
{
    public string Action { get; init; } = Action;
    public string Issue { get; init; } = Issue;

    public void Deconstruct(out string Action, out string Issue)
    {
        Action = this.Action;
        Issue = this.Issue;
    }
}
// Посмотреть насчет других параметров - там есть objects без подписей насчёт того, что именно они содержат
// TODO: issue, assignee, assignees, label, labels