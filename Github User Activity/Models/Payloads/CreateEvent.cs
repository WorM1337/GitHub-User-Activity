namespace Github_User_Activity.Models.Payloads;

public class CreateEvent(string @ref, string refType) : Payload
{
    public string Ref { get; init; } = @ref;
    public string RefType { get; init; } = refType;
}