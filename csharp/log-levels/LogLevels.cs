using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        // throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
        int index = logLine.IndexOf(":") + 1;
        return logLine.Substring(index).Trim();
    }

    public static string LogLevel(string logLine)
    {
        // throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
        int length = logLine.IndexOf("]") - 1;
        return logLine.Substring(1, length: length).ToLower();
    }

    public static string Reformat(string logLine)
    {
        // throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
        string message = Message(logLine);
        string logLevel = LogLevel(logLine);
        return $"{message} ({logLevel})";
    }
}
