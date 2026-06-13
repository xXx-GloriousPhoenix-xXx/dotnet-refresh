namespace REFRESH.GoF.Behavioral._10_Visitor;
public interface IVisitor
{
    void VisitDot(Dot dot);
    void VisitCircle(Circle circle);
    void VisitRectangle(Rectangle rectangle);
    void VisitCompoundShape(CompoundShape compoundShape);
}
