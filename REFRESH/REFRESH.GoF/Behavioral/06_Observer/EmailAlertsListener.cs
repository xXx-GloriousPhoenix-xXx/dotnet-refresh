namespace REFRESH.GoF.Behavioral._06_Observer;

public class EmailAlertsListener(string email, string message) : IEventListener
{
    public void Update(string filename)
    {
        Console.WriteLine($"[Email] Sending to {email}: {string.Format(message, filename)}");
    }
}
