using System;

public static class Logger
{
    public static void Log(string logType, string message)
    {
        string logTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt");
        Console.WriteLine($"{logTime}: {logType}: {message}");
    }
}