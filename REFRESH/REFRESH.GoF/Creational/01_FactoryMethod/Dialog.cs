namespace REFRESH.GoF.Creational._02_FactoryMethod;
public abstract class Dialog
{
    public abstract IButton CreateButton();
    public void Render()
    {
        var button = CreateButton();
        button.Render();
    }
}
