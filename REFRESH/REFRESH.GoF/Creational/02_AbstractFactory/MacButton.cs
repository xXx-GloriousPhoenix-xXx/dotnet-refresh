namespace REFRESH.GoF.Creational._02_AbstractFactory;

public class MacButton : IButton
{
    public void Click()
    {
        Console.WriteLine("Mac button is clicked");
    }

    public void Render()
    {
        Console.WriteLine("Mac button is rendered");
    }
}
