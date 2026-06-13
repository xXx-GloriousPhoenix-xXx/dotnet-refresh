using System.Drawing;
using System.Numerics;

namespace REFRESH.GoF.Structural._06_Flyweight;

public class Unit(Vector2 position)
{
    public Vector2 Position { get; private set; } = position;
    public void FireAt(Unit target)
    {
        Game.AddParticle(Position,
            Vector2.Normalize(target.Position - Position),
            100, Color.Red, "bullet.jpeg");
    }
}