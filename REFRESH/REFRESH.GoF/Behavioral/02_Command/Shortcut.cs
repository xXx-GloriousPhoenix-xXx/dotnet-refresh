namespace REFRESH.GoF.Behavioral._02_Command;

public class Shortcut(Command command)
{
    public void OnKeyPress()
    {
        command.Execute();
    }
}