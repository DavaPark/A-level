using Newtonsoft.Json;

namespace Module3;

public class Logger
{
    private string logFile;
    private int backupThreshold;
    private List<string> logEntries = new List<string>();
    private AutoResetEvent backupEvent = new AutoResetEvent(false);
    private string backupFolder = "Backup";


    public Logger(string logFile, int backupThreshold)
    {
        this.logFile = logFile;
        this.backupThreshold = backupThreshold;
        LoadConfig();
    }

    private void LoadConfig()
    {
        try
        {
            string configJson = File.ReadAllText("config.json");
            dynamic config = Newtonsoft.Json.JsonConvert.DeserializeObject(configJson);
            backupThreshold = config["backup_threshold"] ?? backupThreshold;
        }
        catch (FileNotFoundException)
        {
            
        }
    }

    public async Task WriteLogEntryAsync(string entry)
    {
        logEntries.Add(entry);
        if (logEntries.Count >= backupThreshold)
        {
            backupEvent.Set();
        }
        await Task.Run(() =>
        {
            lock (this)
            {
                File.AppendAllText(logFile, entry + Environment.NewLine);
            }
        });
    }

    public async Task BackupLogsAsync()
    {
        while (true)
        {
            backupEvent.WaitOne();
            string backupFileName = Path.Combine(backupFolder, $"log_backup_{DateTime.Now:yyyyMMddHHmmss}.txt");
            await Task.Run(() =>
            {
                lock (this)
                {
                    File.WriteAllLines(backupFileName, logEntries);
                }
            });
            logEntries.Clear();
            backupEvent.Reset();
        }
    }
}