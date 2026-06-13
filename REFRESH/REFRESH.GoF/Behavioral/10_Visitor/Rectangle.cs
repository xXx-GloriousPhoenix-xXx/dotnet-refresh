namespace REFRESH.GoF.Behavioral._10_Visitor;

public class Rectangle : IShape
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitRectangle(this);
    }

    public void Draw() { }
    public void Move(int x, int y) { }
}
