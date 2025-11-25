namespace Github_User_Activity.Models.Payloads;

public class MemberEvent(string Action) : Payload
{
    public string Action { get; init; } = Action;

    public void Deconstruct(out string Action)
    {
        Action = this.Action;
    }
} // TODO: member - object