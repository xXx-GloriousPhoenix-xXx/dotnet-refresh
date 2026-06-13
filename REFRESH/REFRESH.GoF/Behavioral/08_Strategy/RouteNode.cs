using System.Numerics;

namespace REFRESH.GoF.Behavioral._08_Strategy;

public class RouteNode(float x, float y)
{
    public Vector2 Position { get; init; } = new(x, y);
    public RouteNode? Next { get; set; } = null;
}
