public class LogLine
{
    public static string Message(string full_message)
    {
        int first = full_message.IndexOf(":") + 1;
        
        return full_message[first..].Trim();
    }

    public static string LogLevel(string full_message)
    {
        int first = full_message.IndexOf("[") + 1;
        int last = full_message.IndexOf("]");
        
        return full_message[first..last].ToLower();
    }

    public static string Reformat(string full_message)
    {
        string log_level = LogLevel(full_message);
        string message = Message(full_message);
        
        return $"{message} ({log_level})";
    }
}