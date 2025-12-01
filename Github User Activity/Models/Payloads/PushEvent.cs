namespace Github_User_Activity.Models.Payloads;

public class PushEvent(long repositoryId, long pushId, string @ref, string head, string before) : Payload
{
    public long RepositoryId { get; init; } = repositoryId;
    public long PushId { get; init; } = pushId;
    public string Ref { get; init; } = @ref;
    public string Head { get; init; } = head;
    public string Before { get; init; } = before;

    public override string GetFormattedInto()
    {
        return $"\tRepository Id: {RepositoryId}\n" +
               $"\tPush Id: {PushId}\n" +
               $"\tRef: {Ref}\n" +
               $"\tHead: {Head}\n" +
               $"\tBefore: {Before}\n";
    }
}