namespace REFRESH.GoF.Behavioral._10_Visitor;

public class Circle : IShape
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitCircle(this);
    }

    public void Draw() { }
    public void Move(int x, int y) { }
}
