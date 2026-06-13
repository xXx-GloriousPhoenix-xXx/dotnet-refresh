namespace REFRESH.GoF.Behavioral._10_Visitor;

public class Dot : IShape
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitDot(this);
    }

    public void Draw() { }
    public void Move(int x, int y) { }
}
