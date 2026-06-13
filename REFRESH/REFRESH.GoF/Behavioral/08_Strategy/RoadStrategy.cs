namespace REFRESH.GoF.Behavioral._08_Strategy;

public class RoadStrategy : IRouteStrategy
{
    public int IntermediateDots => 10;

    public RouteNode BuildRoute(RouteNode a, RouteNode b)
    {
        var (x0, y0) = (a.Position.X, a.Position.Y);
        var (x1, y1) = (b.Position.X, b.Position.Y);

        var coefA = (y1 - y0 - x1 * x1 + x0 * x0) / (x1 - x0);
        var coefB = y0 - x0 * x0 - coefA * x0;

        float function(float x) => x * x + coefA * x + coefB;

        return BuildChain(a, b, function, IntermediateDots);
    }

    private static RouteNode BuildChain(
        RouteNode a, RouteNode b,
        Func<float, float> function,
        int intermediateDots)
    {
        var x0 = a.Position.X;
        var x1 = b.Position.X;
        var step = (x1 - x0) / (intermediateDots + 1);

        var curr = a;
        for (var i = 1; i <= intermediateDots; i++)
        {
            var x = x0 + step * i;
            var y = function(x);
            var node = new RouteNode(x, y);
            curr.Next = node;
            curr = node;
        }
        curr.Next = b;

        return a;
    }
}
