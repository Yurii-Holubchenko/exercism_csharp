public static class LogAnalysis
{
    public static string SubstringAfter(this string message, string separator)
    {        
        int start = message.IndexOf(separator.Last()) + 1;
        
        return message.Substring(start);
    }

    public static string SubstringBetween(this string message, string start_from, string end_with)
    {
        int start = message.IndexOf(start_from) + start_from.Length;
        int length = message.IndexOf(end_with) - start;
        
        return message.Substring(start, length);
    }

    public static string Message(this string message)
    {
        return message.SubstringAfter("]:").Trim();
    }

    public static string LogLevel(this string message)
    {
        return message.SubstringBetween("[", "]");
    }
}