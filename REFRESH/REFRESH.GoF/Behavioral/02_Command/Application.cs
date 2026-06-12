namespace REFRESH.GoF.Behavioral._02_Command;

public class Application
{
    public List<Editor> Editors { get; private set; } = [];
    public Editor? ActiveEditor { get; private set; } = null;
    public string? Clipboard { get; private set; }
    public CommandHistory History { get; private set; } = new();
    public void SetActiveEditor(Editor editor)
    {
        ActiveEditor = editor;
    }

    public void SetClipboard(string text)
    {
        Clipboard = text;
    }

    public void ExecuteCommand(Command command)
    {
        command.Execute();
    }

    public void Undo()
    {
        var command = History.Pop();
        command?.Undo();
    }
}
