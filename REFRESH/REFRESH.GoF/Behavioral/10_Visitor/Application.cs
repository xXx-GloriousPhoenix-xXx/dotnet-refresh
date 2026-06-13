namespace REFRESH.GoF.Behavioral._10_Visitor;
public class Application(IVisitor visitor)
{
    private readonly List<IShape> _shapes = [];
    private readonly IVisitor _visitor = visitor;
    public void Add(IShape shape) => _shapes.Add(shape);
    public void Export()
    {
        foreach (var shape in _shapes)
        {
            shape.Accept(_visitor);
        }
    }
}