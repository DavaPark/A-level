using System.Diagnostics;

namespace HomeWork16;

class Program
{
    
    static async Task Main(string[] args)
    {
        var watch = Stopwatch.StartNew();
        await CreateHelloWorldFiles();

        string result = await ConcatenateTextAsync();
        Console.WriteLine(result);
        watch.Stop();
        Console.WriteLine($"Look{watch.Elapsed.TotalSeconds} seconds");
        Console.ReadLine();
    }

    static async Task CreateHelloWorldFiles()
    {
        string helloText = "Hello";
        string worldText = "World";

        await WriteTextToFileAsync("Hello.txt", helloText);
        await WriteTextToFileAsync("World.txt", worldText);
    }

    static async Task WriteTextToFileAsync(string filePath, string text)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            await writer.WriteAsync(text);
        }
    }

    static async Task<string> ReadFromFileAsync(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            return await reader.ReadToEndAsync();
        }
    }

    static async Task<string> ConcatenateTextAsync()
    {
        Task<string> helloTask = ReadFromFileAsync("Hello.txt");
        Task<string> worldTask = ReadFromFileAsync("World.txt");

        string helloText = await helloTask;
        string worldText = await worldTask;

        return $"{helloText} {worldText}";
    }
}