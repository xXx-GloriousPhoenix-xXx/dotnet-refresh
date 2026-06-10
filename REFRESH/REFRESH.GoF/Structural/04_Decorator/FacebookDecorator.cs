namespace REFRESH.GoF.Structural._04_Decorator;

public class FacebookDecorator(Notifier wrappee) : BaseDecorator(wrappee)
{
    public override void SendMessage(string message)
    {
        Console.WriteLine("Sending via Facebook");
        base.SendMessage(message);
    }
}
