namespace REFRESH.GoF.Behavioral._08_Strategy;

public class Navigator : IRouteStrategy
{
    private IRouteStrategy? _strategy;
    public void SetStrategy(IRouteStrategy strategy) => _strategy = strategy;

    public int IntermediateDots => _strategy?.IntermediateDots ?? 0;
    public RouteNode BuildRoute(RouteNode a, RouteNode b) =>
        _strategy?.BuildRoute(a, b) ?? a;
}
