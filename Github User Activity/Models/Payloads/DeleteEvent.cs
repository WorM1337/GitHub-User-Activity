namespace Github_User_Activity.Models.Payloads;

public class DeleteEvent(string @ref, string refType, string fullRef, string pusherType) : Payload
{
    public string Ref { get; init; } = @ref;
    public string RefType { get; init; } = refType;
    public string FullRef { get; init; } = fullRef;
    public string PusherType { get; init; } = pusherType;
}