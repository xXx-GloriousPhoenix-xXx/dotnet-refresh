namespace REFRESH.GoF.Structural._03_Composite;

public class Box : INode
{
    private readonly List<INode> _nodes = [];
    public IReadOnlyCollection<INode> Nodes => _nodes;
    public void AddNode(INode node)
    {
        _nodes.Add(node);
    }
    public void RemoveNode(INode node)
    {
        _nodes.Remove(node);
    }
    public decimal Total()
    {
        return _nodes.Sum(n => n.Total());
    }
}
