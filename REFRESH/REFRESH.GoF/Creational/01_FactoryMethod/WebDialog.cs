namespace REFRESH.GoF.Creational._02_FactoryMethod;

public class WebDialog : Dialog
{
    public override IButton CreateButton()
    {
        return new HTMLButton();
    }
}