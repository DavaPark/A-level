using Module3;
using System;
using System.Threading.Tasks;

namespace Module3;

public class App
{
    private Logger logger;

    public App(Logger logger)
    {
        this.logger = logger;
    }

    public async Task MakeLogEntriesAsync(int count)
    {
        for (int i = 0; i < count; i++)
        {
            await logger.WriteLogEntryAsync($"Log entry {i}");
            await Task.Delay(100);
        }
    }
}