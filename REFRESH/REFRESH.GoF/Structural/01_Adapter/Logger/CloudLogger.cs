namespace REFRESH.GoF.Structural._01_Adapter.Logger;

public class CloudLogger
{
    public void SendMessage(CloudLogLevel level, string textMessage)
    {
        Console.WriteLine($"[Cloud API] [{level}]: {textMessage}");
    }
}
