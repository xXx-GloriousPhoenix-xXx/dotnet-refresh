namespace REFRESH.GoF.Behavioral._05_Memento;

public class History
{
    private readonly Stack<IMemento> _history = new();

    public void Push(IMemento memento)
    {
        _history.Push(memento);
    }

    public IMemento? Pop()
    {
        return _history.Count > 0 ? _history.Pop() : null;
    }
}