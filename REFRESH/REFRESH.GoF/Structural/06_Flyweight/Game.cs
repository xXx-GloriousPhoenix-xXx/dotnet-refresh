using System.Drawing;
using System.Numerics;

namespace REFRESH.GoF.Structural._06_Flyweight;

public static class Game
{
    public static List<MovingParticle> MPS { get; private set; } = [];
    private static readonly List<Particle> _particles = [];
    public static void AddParticle(Vector2 position, Vector2 direction, float speed, Color color, string texturePath)
    {
        var particle = _particles.FirstOrDefault(p => p.TexturePath == texturePath && p.Color == color);
        if (particle is null)
        {
            particle = new Particle(texturePath, color);
            _particles.Add(particle);
        }

        var mp = new MovingParticle(particle, position, direction, speed);
        MPS.Add(mp);
    }
    public static void Draw(Canvas canvas)
    {
        foreach (var mp in MPS)
        {
            mp.Draw(canvas);
        }
    }
}
