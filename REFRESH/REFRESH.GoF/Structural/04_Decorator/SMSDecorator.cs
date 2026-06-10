namespace REFRESH.GoF.Structural._04_Decorator;

public class SMSDecorator(Notifier wrappee) : BaseDecorator(wrappee)
{
    public override void SendMessage(string message)
    {
        Console.WriteLine("Sending via SMS");
        base.SendMessage(message);
    }
}
