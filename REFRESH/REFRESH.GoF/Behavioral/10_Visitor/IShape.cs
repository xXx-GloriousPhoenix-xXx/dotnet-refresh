namespace REFRESH.GoF.Behavioral._10_Visitor;

public interface IShape
{
    void Move(int x, int y);
    void Draw();
    void Accept(IVisitor visitor);
}
