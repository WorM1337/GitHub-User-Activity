namespace Github_User_Activity.Models.Payloads;

public class PushEvent(long RepositoryId, long PushId, string Ref, string Head, string Before) : Payload
{
    public long RepositoryId { get; init; } = RepositoryId;
    public long PushId { get; init; } = PushId;
    public string Ref { get; init; } = Ref;
    public string Head { get; init; } = Head;
    public string Before { get; init; } = Before;

    public void Deconstruct(out long RepositoryId, out long PushId, out string Ref, out string Head, out string Before)
    {
        RepositoryId = this.RepositoryId;
        PushId = this.PushId;
        Ref = this.Ref;
        Head = this.Head;
        Before = this.Before;
    }
}