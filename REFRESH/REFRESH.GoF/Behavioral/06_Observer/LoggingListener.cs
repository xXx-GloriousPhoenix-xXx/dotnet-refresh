namespace REFRESH.GoF.Behavioral._06_Observer;

public class LoggingListener(string logFile, string message) : IEventListener
{
    public void Update(string filename)
    {
        Console.WriteLine($"[Logger] Saving to {logFile}: {string.Format(message, filename)}");
    }
}
