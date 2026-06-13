using System.Numerics;

namespace REFRESH.GoF.Structural._06_Flyweight;

public class MovingParticle(Particle particle, Vector2 position, Vector2 direction, float speed)
{
    private readonly Particle _particle = particle;
    public Vector2 Position { get; private set; } = position;
    public Vector2 Direction { get; private set; } = direction;
    public float Speed { get; private set; } = speed;
    public void Move() => Position = _particle.Move(Position, Direction, Speed);
    public void Draw(Canvas canvas) => _particle.Draw(Position, canvas);
}
