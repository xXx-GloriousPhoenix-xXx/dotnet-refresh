namespace REFRESH.GoF.Creational._02_AbstractFactory;
public class Application(IGUIFactory factory)
{
    private readonly IGUIFactory _factory = factory;
    private IButton? _button;
    private Checkbox? _checkbox;

    public void CreateUI()
    {
        _button = _factory.CreateButton();
        _checkbox = _factory.CreateCheckbox();
    }

    public void RenderUI()
    {
        if (_button is null)
        {
            throw new ArgumentNullException("Button is not created");
        }
        _button.Render();

        if (_checkbox is null)
        {
            throw new ArgumentNullException("Checkbox is not created");
        }
        _checkbox.Render();
    }
}
