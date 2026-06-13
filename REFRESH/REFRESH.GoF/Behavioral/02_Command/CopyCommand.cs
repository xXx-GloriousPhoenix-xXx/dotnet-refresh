namespace REFRESH.GoF.Behavioral._02_Command;

public class CopyCommand(Application app, Editor editor) : Command(app, editor)
{
    public override void Execute()
    {
        _app.SetClipboard(_editor.GetSelection());
    }
}
