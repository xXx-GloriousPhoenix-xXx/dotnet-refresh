using REFRESH.GoF.Behavioral._08_Strategy;

var navigator = new Navigator();
navigator.SetStrategy(new RoadStrategy());
var a = new RouteNode(1, 1);
var b = new RouteNode(5, 5);
var path = navigator.BuildRoute(a, b);
while (path != null)
{
    Console.WriteLine(path.Position);
    path = path.Next;
}