namespace REFRESH.GoF.Behavioral._02_Command;

public class Button(Command command)
{
    public void OnClick()
    {
        command.Execute();
    }
}
