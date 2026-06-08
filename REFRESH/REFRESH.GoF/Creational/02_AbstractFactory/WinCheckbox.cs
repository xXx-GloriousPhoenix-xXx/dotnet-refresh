namespace REFRESH.GoF.Creational._02_AbstractFactory;

public class WinCheckbox : Checkbox
{
    public override bool Check()
    {
        _checked = !_checked;
        Console.WriteLine($"Windows checkbox is {(_checked ? "" : "un")}checked");
        return _checked;
    }

    public override void Render()
    {
        Console.WriteLine("Windows checkbox is rendered");
    }
}
