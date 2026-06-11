namespace REFRESH.GoF.Behavioral._01_ChainOfResponsibility;

public class Container : Component
{
    private readonly List<Component> _children = [];
    public void AddChild(Component child)
    {
        _children.Add(child);
        child.SetNext(this);
    }
}
