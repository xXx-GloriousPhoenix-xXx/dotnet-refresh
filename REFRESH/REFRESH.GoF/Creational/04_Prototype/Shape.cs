namespace REFRESH.GoF.Creational._04_Prototype;
public abstract class Shape(int x, int y, string color)
{
    protected int _x = x;
    protected int _y = y;
    protected string _color = color;
    public abstract Shape Clone();
}
