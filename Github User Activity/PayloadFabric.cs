using System.Text.Json;
using Github_User_Activity.Models.Payloads;

namespace Github_User_Activity;

public static class PayloadFabric
{
    public static Payload? GetPayloadByString(string type, string payload)
    {
        var options = ConfigService.ReadSerializerOptions;
        switch (type)
        {
            case "CommitCommentEvent":
                return JsonSerializer.Deserialize<CommitCommentEvent>(payload,  options);
            case  "CreateEvent":
                return JsonSerializer.Deserialize<CreateEvent>(payload,  options);
            case  "DeleteEvent":
                return JsonSerializer.Deserialize<DeleteEvent>(payload,  options);
            case  "DiscussionEvent":
                return JsonSerializer.Deserialize<DiscussionEvent>(payload,  options);
            case  "ForkEvent":
                return JsonSerializer.Deserialize<ForkEvent>(payload,  options);
            case  "GollumEvent":
                return JsonSerializer.Deserialize<GollumEvent>(payload,  options);
            case  "IssueCommentEvent":
                return JsonSerializer.Deserialize<IssueCommentEvent>(payload,   options);
            case  "IssuesEvent":
                return JsonSerializer.Deserialize<IssuesEvent>(payload,  options);
            case  "MemberEvent":
                return JsonSerializer.Deserialize<MemberEvent>(payload,  options);
            case  "PublicEvent":
                return JsonSerializer.Deserialize<PublicEvent>(payload,  options);
            case  "PullRequestEvent":
                return JsonSerializer.Deserialize<PullRequestEvent>(payload,  options);
            case  "PullRequestReviewCommentEvent":
                return JsonSerializer.Deserialize<PullRequestReviewCommentEvent>(payload,   options);
            case  "PullRequestReviewEvent":
                return JsonSerializer.Deserialize<PullRequestReviewEvent>(payload,  options);
            case  "PushEvent":
                return JsonSerializer.Deserialize<PushEvent>(payload,   options);
            case  "ReleaseEvent":
                return JsonSerializer.Deserialize<ReleaseEvent>(payload,  options);
            case  "WatchEvent":
                return JsonSerializer.Deserialize<WatchEvent>(payload,  options);
            default:
                throw new Exception("Unknown payload type");
        }
    }
}