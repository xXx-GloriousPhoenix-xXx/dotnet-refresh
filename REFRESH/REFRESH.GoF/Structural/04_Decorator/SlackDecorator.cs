namespace REFRESH.GoF.Structural._04_Decorator;

public class SlackDecorator(Notifier wrappee) : BaseDecorator(wrappee)
{
    public override void SendMessage(string message)
    {
        Console.WriteLine("Sending via Slack");
        base.SendMessage(message);
    }
}