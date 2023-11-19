namespace CopilotCsharp.Library;

public class Regex
{
    public static bool JustARegex(string domain)
    {
        string pattern = @"^((?!-)[A-Za-z0-9-]{1,63}(?<!-)\\.)+[A-Za-z]{2,6}$";
        return System.Text.RegularExpressions.Regex.IsMatch(domain, pattern);
    }
    
    // function that validates the format of URL
}