namespace REFRESH.GoF.Behavioral._02_Command;

public class UndoCommand(Application app, Editor editor) : Command(app, editor)
{
    public override void Execute()
    {
        _app.Undo();
    }
}
