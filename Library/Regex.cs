namespace CopilotCsharp.Library;

public class Regex
{
    public static bool JustARegex(string domain)
    {
        string pattern = @"^((?!-)[A-Za-z0-9-]{1,63}(?<!-)\\.)+[A-Za-z]{2,6}$";
        return System.Text.RegularExpressions.Regex.IsMatch(domain, pattern);
    }
    
    // function that validates the format of URL
    public static bool IsValidUrl(string url)
    {
        // regex pattern for URL
        string pattern = @"^(https?:\\/\\/)?(www\\.)?([\\w]+\\.)+[‌​\\w]{2,63}\\/?$";

        // return true if URL matches pattern
        return System.Text.RegularExpressions.Regex.IsMatch(url, pattern);
    }
}