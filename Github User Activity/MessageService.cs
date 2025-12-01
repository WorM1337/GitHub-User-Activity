using Github_User_Activity.Models.Payloads;

namespace Github_User_Activity;

public static class MessageService
{
    public static string GetResponse(string type, Payload payload, DateTime createdAt)
    {
        var startStr = $"Type: {type}. \n";
        var endStr = $"CreatedAt: {createdAt} \n";
        
        return startStr + payload.GetFormattedInto() + endStr;
    }
}