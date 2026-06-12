namespace REFRESH.GoF.Behavioral._02_Command;

public class PasteCommand(Application app, Editor editor) : Command(app, editor)
{
    public override void Execute()
    {
        SaveBackup();
        _editor.ReplaceSelection(_app.Clipboard ?? string.Empty);
        _app.History.Push(this);
    }
}
