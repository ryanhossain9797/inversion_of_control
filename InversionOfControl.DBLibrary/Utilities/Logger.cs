namespace DBLibrary;

public class Logger : ILogger
{

    public Logger()
    {
        Console.WriteLine("Initialized Logger");
    }
    public void Log(String message)
    {
        Console.WriteLine($"Log: {message}");
    }
}