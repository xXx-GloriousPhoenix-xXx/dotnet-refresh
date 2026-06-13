namespace REFRESH.GoF.Creational._04_Prototype;

public class Circle(int x, int y, string color, uint radius) : Shape(x, y, color)
{
    private readonly uint _radius = radius;
    public override Shape Clone()
    {
        return new Circle(_x, _y, _color, _radius);
    }
}
