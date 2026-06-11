using System.Numerics;

namespace REFRESH.GoF.Structural._06_Flyweight;

public class Canvas
{
    public void Draw(Vector2 position)
    {
        Console.WriteLine($"({position.X}, {position.Y})");
    }
}
