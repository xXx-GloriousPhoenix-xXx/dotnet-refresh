namespace REFRESH.GoF.Behavioral._08_Strategy;

public interface IRouteStrategy
{
    int IntermediateDots { get; }
    RouteNode BuildRoute(RouteNode a, RouteNode b);
}
