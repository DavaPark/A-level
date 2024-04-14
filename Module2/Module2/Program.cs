class Program
{
    static void Main()
    {
        try
        {
            Startup.App();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}