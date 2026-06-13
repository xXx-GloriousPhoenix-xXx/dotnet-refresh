namespace REFRESH.GoF.Creational._04_Prototype;

public class Rectangle(int x, int y, string color, uint width, uint height) : Shape(x, y, color)
{
    private readonly uint _width = width;
    private readonly uint _height = height;
    public override Shape Clone()
    {
        return new Rectangle(_x, _y, _color, _width, _height);
    }
}
