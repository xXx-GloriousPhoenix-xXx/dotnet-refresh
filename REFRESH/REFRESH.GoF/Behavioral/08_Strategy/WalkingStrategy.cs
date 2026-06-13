namespace REFRESH.GoF.Behavioral._08_Strategy;

public class WalkingStrategy : IRouteStrategy
{
    public int IntermediateDots => 5;

    public RouteNode BuildRoute(RouteNode a, RouteNode b)
    {
        var start = a.Position;
        var end = b.Position;

        var diff = start - end;
        var tanAngle = diff.Y / diff.X;
        var yIntercept = start.Y - tanAngle * start.X;

        float function(float x) => tanAngle * x + yIntercept;
        var totalDots = IntermediateDots + 2;
        var dotDistance = diff.X / totalDots;

        var head = a;
        var curr = a;
        for (var i = 0; i < IntermediateDots; i++)
        {
            var index = i + 1;
            var x = dotDistance * index + diff.X;
            var y = function(x);
            var node = new RouteNode(x, y);
            curr.Next = node;
            curr = node;
        }
        curr.Next = b;

        return head;
    }
}
