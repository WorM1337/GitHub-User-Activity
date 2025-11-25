namespace Github_User_Activity.Models.Payloads;

public class WatchEvent(string Action) : Payload
{
    public string Action { get; init; } = Action;

    public void Deconstruct(out string Action)
    {
        Action = this.Action;
    }
}