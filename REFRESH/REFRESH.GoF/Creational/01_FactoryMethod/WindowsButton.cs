namespace REFRESH.GoF.Creational._02_FactoryMethod;

public class WindowsButton : IButton
{
    public void OnClick()
    {
        Console.WriteLine("Windows Button is rendered");
    }

    public void Render()
    {
        Console.WriteLine("Windows Button is clicked");
    }
}