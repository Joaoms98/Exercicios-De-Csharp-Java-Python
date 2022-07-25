using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int start = logLine.IndexOf(":") + 1;
        return logLine.Substring(start).Trim();
        //Assert.Equal("Stack overflow", LogLine.Message("[ERROR]: Stack overflow"));
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf("[") + 1;
        int end = logLine.IndexOf("]") - 1;
        return logLine.Substring(start, end).ToLower();
        //Assert.Equal("error", LogLine.LogLevel("[ERROR]: Disk full"));
    }

    public static string Reformat(string logLine)
    {
        string error = LogLevel(logLine);
        string message = Message(logLine);
        return (message + " (" + error + ")");
        //Assert.Equal("Segmentation fault (error)", LogLine.Reformat("[ERROR]: Segmentation fault"));
    }
}
