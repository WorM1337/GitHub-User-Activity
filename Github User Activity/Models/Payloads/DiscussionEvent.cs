namespace Github_User_Activity.Models.Payloads;

public class DiscussionEvent(string action, string discussion) : Payload
{
    public string Action { get; init; } = action;
    public string Discussion { get; init; } = discussion;
    public override string GetFormattedInto()
    {
        return $"\tAction: {Action}\n" +
               $"\tDiscussion: {Discussion}\n";
    }
}