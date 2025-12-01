using System.Text.Json;

namespace Github_User_Activity.Models.Payloads;

public class MemberEvent(string action, JsonElement member) : Payload
{
    public string Action { get; init; }  = action;
    public JsonElement Member { get; init; } = member;
    public override string GetFormattedInto()
    {
        return $"\tAction: {Action}" + "\n" +
               $"\tMember: " + FormatJson(Member) + "\n";
    }
}