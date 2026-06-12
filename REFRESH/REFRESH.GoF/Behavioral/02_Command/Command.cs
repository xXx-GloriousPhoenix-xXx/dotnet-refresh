namespace REFRESH.GoF.Behavioral._02_Command;

public abstract class Command(Application app, Editor editor)
{
    protected readonly Application _app = app;
    protected Editor _editor = editor;
    protected Editor _backup = (Editor)editor.Clone();
    public void SaveBackup()
    {
        _backup = (Editor)_editor.Clone();
    }
    public void Undo()
    {
        _editor = (Editor)_backup.Clone();
    }
    public abstract void Execute();
}
