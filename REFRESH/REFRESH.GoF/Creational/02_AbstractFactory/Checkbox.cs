namespace REFRESH.GoF.Creational._02_AbstractFactory;

public abstract class Checkbox
{
    protected bool _checked = false;
    public abstract bool Check();
    public abstract void Render();
}
