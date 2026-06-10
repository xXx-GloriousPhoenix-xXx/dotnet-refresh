namespace REFRESH.GoF.Structural._04_Decorator;
public class Notifier
{
    public virtual void SendMessage(string message)
    {
        Console.WriteLine(message);
    }
}
