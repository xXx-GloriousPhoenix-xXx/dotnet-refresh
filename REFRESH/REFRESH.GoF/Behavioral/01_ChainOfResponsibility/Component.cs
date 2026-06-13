namespace REFRESH.GoF.Behavioral._01_ChainOfResponsibility;

public abstract class Component : IComponentWithContextualHelp
{
    private IComponentWithContextualHelp? _nextHandler;
    protected string? HelpText;

    public IComponentWithContextualHelp SetNext(IComponentWithContextualHelp nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public virtual void ShowHelp()
    {
        if (!string.IsNullOrEmpty(HelpText))
        {
            Console.WriteLine($"[Help] {HelpText}");
        }
        else if (_nextHandler is not null)
        {
            _nextHandler.ShowHelp();
        }
        else
        {
            Console.WriteLine($"[Help] Help not found");
        }
    }
}
