using System.Drawing;
using System.Numerics;

namespace REFRESH.GoF.Structural._06_Flyweight;

public class Particle(string texturePath, Color color)
{
    public string TexturePath { get; private set; } = texturePath;
    public Color Color { get; private set; } = color;
    public Vector2 Move(Vector2 position, Vector2 direction, float speed) => position + direction * speed;
    public void Draw(Vector2 position, Canvas canvas) => canvas.Draw(position);
}
