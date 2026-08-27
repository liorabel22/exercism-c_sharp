static class LogLine
{
    public static string Message(string logLine)
    {
        string[] splitArray = logLine.Split(':');
        return splitArray[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        char[] delimiters = ['[', ']'];
        string[] splitArray = logLine.Split(delimiters);

        return splitArray[1].ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string logLevel = LogLevel(logLine);

        return $"{message} ({logLevel})";
    }
}
