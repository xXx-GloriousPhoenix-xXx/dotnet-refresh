namespace REFRESH.GoF.Creational._02_AbstractFactory;
public interface IGUIFactory
{
    IButton CreateButton();
    Checkbox CreateCheckbox();
}
public class WinFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WinButton();
    }

    public Checkbox CreateCheckbox()
    {
        return new WinCheckbox();
    }
}
public class MacFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public Checkbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}
