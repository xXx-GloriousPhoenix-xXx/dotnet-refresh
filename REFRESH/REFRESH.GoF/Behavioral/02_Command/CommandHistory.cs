namespace REFRESH.GoF.Behavioral._02_Command;

public class CommandHistory
{
    private readonly List<Command> _history = [];
    public void Push(Command command)
    {
        _history.Add(command);
    }
    public Command? Pop()
    {
        if (_history.Count == 0)
        {
            return null;
        }

        var lastIndex = _history.Count - 1;
        var command = _history[lastIndex];
        _history.RemoveAt(lastIndex);
        return command;
    }
}
