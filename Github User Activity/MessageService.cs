using Github_User_Activity.Models.Payloads;

namespace Github_User_Activity;

public class MessageService
{
    public string GetResponse(string type, Payload payload, DateTime createdAt)
    {
        var startStr = $"Type: {type}. \n";
        var endStr = $"CreatedAt: {createdAt} \n";
        
        return payload switch
        {
            CommitCommentEvent e => startStr + "",
            CreateEvent e => startStr + "",
            DeleteEvent e => startStr + "",
            DiscussionEvent e => startStr + "",
            ForkEvent e => startStr + "",
            GollumEvent e => startStr + "",
            IssueCommentEvent e => startStr + "",
            IssuesEvent e => startStr + "",
            MemberEvent e => startStr + "",
            PublicEvent e => startStr + "",
            PullRequestEvent e => startStr + "",
            PullRequestReviewCommentEvent e => startStr + "",
            PullRequestReviewEvent e => startStr + "",
            PushEvent e => startStr + 
                           $"\tRepository Id: {e.RepositoryId}\n" +
                           $"\tPush Id: {e.PushId}\n" +
                           $"\tRef: {e.Ref}\n" +
                           $"\tHead: {e.Head}\n" +
                           $"\tBefore: {e.Before}\n",
            ReleaseEvent e => startStr + "",
            WatchEvent e => startStr + "",
            _ => startStr + "Unknown event type"
        } + endStr;
    }
}