namespace Github_User_Activity;

public static class TabulationFormatter
{
    public static string FormatTextTabulation(string? text, int firstTabs = 1)
    {
        if (text == null)
            return "";
        string[] strings = text.Split("\n");

        var ans = strings[0] + "\n";

        for(int i = 1;  i < strings.Length; i++)
        {
            int iter = firstTabs;
            while(iter-- != 0) ans += "\t";
            ans += strings[i] + "\n";
        }

        return ans;
    }

    public static string FormatStringTabulation(string? text, int firstTabs = 1)
    {
        if (text == null)
            return "";
        var ans = "";
        while (firstTabs-- > 0)
        {
            ans += "\t";
        }
        ans += text;
        return ans;
    }
}