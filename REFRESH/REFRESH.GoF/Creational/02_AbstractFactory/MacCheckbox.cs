namespace REFRESH.GoF.Creational._02_AbstractFactory;

public class MacCheckbox : Checkbox
{
    public override bool Check()
    {
        _checked = !_checked;
        Console.WriteLine($"Mac checkbox is {(_checked ? "" : "un")}checked");
        return _checked;
    }

    public override void Render()
    {
        Console.WriteLine("Mac checkbox is rendered");
    }
}
