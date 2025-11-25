namespace Github_User_Activity.Models.Payloads;

public class GollumEvent(Page[] Pages) : Payload
{
    public Page[] Pages { get; init; } = Pages;

    public void Deconstruct(out Page[] Pages)
    {
        Pages = this.Pages;
    }
}

public class Page(string pageName = "", string title = "", string action = "", string sha = "", string url = "")
{
    public string PageName { get; set; } = pageName;
    public string Title { get; set; } = title;
    public string Action { get; set; } = action;
    public string Sha { get; set; } = sha;
    public string HtmlUrl { get; set; } = url;
}