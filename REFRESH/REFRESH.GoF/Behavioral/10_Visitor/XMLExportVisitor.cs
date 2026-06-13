namespace REFRESH.GoF.Behavioral._10_Visitor;

public class XMLExportVisitor : IVisitor
{
    public void VisitDot(Dot dot) => Console.WriteLine("<dot>...</dot>");

    public void VisitCircle(Circle circle) => Console.WriteLine("<circle>...</circle>");

    public void VisitRectangle(Rectangle rectangle) => Console.WriteLine("<rectangle>...</rectangle>");

    public void VisitCompoundShape(CompoundShape compoundShape)
    {
        Console.WriteLine("<compound_shape>");
        foreach (var shape in compoundShape.Children)
        {
            shape.Accept(this);
        }
        Console.WriteLine("</compound_shape>");
    }
}
