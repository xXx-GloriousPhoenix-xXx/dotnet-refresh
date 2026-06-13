namespace REFRESH.GoF.Behavioral._02_Command;

public class CutCommand(Application app, Editor editor) : Command(app, editor)
{
    public override void Execute()
    {
        SaveBackup();
        _app.SetClipboard(_editor.GetSelection());
        _editor.RemoveSelection();
        _app.History.Push(this);
    }
}
