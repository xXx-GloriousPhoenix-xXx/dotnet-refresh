namespace REFRESH.GoF.Creational._02_FactoryMethod;

public class WindowsDialog : Dialog
{
    public override IButton CreateButton()
    {
        return new WindowsButton();
    }
}
