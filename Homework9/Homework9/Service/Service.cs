using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

public static class FileService
{
    public static void WriteToFile(object logData)
    {
        string logTime = DateTime.Now.ToString("MMddyyyyHHmmssfff");
        string fileName = $"{logTime}.txt";
        string filePath = Path.Combine("logs", fileName);

        string jsonData = JsonConvert.SerializeObject(logData);

        File.WriteAllText(filePath, jsonData);

        CleanUpFiles();
    }

    private static void CleanUpFiles()
    {
        string directory = "logs";
        string[] files = Directory.GetFiles(directory);

        if (files.Length > 3)
        {
            string oldestFile = files.OrderBy(f => new FileInfo(f).CreationTime).First();
            File.Delete(oldestFile);
        }
    }
}