namespace REFRESH.GoF.Behavioral._10_Visitor;

public class CompoundShape : IShape
{
    public List<IShape> Children { get; } = [];
    public void Accept(IVisitor visitor)
    {
        visitor.VisitCompoundShape(this);
    }
    public void Add(IShape shape) => Children.Add(shape);

    public void Draw() { }
    public void Move(int x, int y) { }
}