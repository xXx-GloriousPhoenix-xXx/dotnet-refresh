namespace REFRESH.GoF.Creational._02_FactoryMethod;

public class HTMLButton : IButton
{
    public void Render()
    {
        Console.WriteLine("HTML Button is rendered");
    }

    public void OnClick()
    {
        Console.WriteLine("HTML Button is clicked");
    }
}
