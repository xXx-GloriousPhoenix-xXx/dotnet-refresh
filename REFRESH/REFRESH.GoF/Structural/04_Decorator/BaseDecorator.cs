namespace REFRESH.GoF.Structural._04_Decorator;

public class BaseDecorator(Notifier wrappee) : Notifier
{
    private readonly Notifier _wrappee = wrappee;
    public override void SendMessage(string message)
    {
        _wrappee.SendMessage(message);
    }
}
