namespace Github_User_Activity.Models.Payloads;

public class ForkEvent(string Action) : Payload
{
    public string Action { get; init; } = Action;

    public void Deconstruct(out string Action)
    {
        Action = this.Action;
    }
}
// Как то не понятно насчет forkee - что это вообще такое