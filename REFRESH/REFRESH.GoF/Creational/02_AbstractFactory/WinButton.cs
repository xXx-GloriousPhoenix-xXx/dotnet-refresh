namespace REFRESH.GoF.Creational._02_AbstractFactory;

public class WinButton : IButton
{
    public void Click()
    {
        Console.WriteLine("Windows button is clicked");
    }

    public void Render()
    {
        Console.WriteLine("Windows button is rendered");
    }
}
