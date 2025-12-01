namespace Github_User_Activity.Models.Payloads;

public class GollumEvent(Page[] pages) : Payload
{
    public Page[] Pages { get; init; } = pages;
    public override string GetFormattedInto()
    {
        var ans = "\tPages: \n";

        var iter = 1;
        foreach (var page in Pages)
        {
            ans += $"№{iter++}:";
            ans += "\t" + TabulationFormatter.FormatTextTabulation(page.ToString(), 2);
        }

        return ans;
    }
}

public class Page(string pageName = "", string title = "", string action = "", string sha = "", string url = "")
{
    public string PageName { get; init; } = pageName;
    public string Title { get; init; } = title;
    public string Action { get; init; } = action;
    public string Sha { get; init; } = sha;
    public string HtmlUrl { get; init; } = url;

    public override string ToString()
    {
        return $"PageName: {PageName}\n" +
               $"Title: {Title}\n" +
               $"Action: {Action}\n" +
               $"Sha: {Sha}\n" +
               $"HtmlUrl: {HtmlUrl}\n";
    }
}