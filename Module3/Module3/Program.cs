namespace Module3;

class Program
{
    static async Task Main(string[] args)
    {
        Logger logger = new Logger("log.txt", backupThreshold: 10);
        App app = new App(logger);

        var task1 = app.MakeLogEntriesAsync(50);
        var task2 = app.MakeLogEntriesAsync(50);
        var backupTask = logger.BackupLogsAsync();

        await Task.WhenAll(task1, task2, backupTask);
    }
}