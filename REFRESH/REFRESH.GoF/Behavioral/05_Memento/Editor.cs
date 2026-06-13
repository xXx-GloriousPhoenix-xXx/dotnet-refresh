using System.Numerics;

namespace REFRESH.GoF.Behavioral._05_Memento;
public class Editor
{
    private string _text = "";
    private Vector2 _cursorPos = Vector2.Zero;
    private string _currentFont = "Arial";
    private List<string> _styles = [];

    public History History { get; init; } = new();

    public void SetState(string text, Vector2 cursorPos, string currentFont, List<string> styles)
    {
        _text = text;
        _cursorPos = cursorPos;
        _currentFont = currentFont;
        _styles = [.. styles];
    }

    public IMemento CreateSnapshot()
    {
        return new EditorMemento(_text, _cursorPos, _currentFont, _styles);
    }

    public void Restore(IMemento memento)
    {
        if (memento is EditorMemento concreteMemento)
        {
            _text = concreteMemento.Text;
            _cursorPos = concreteMemento.CursorPos;
            _currentFont = concreteMemento.CurrentFont;
            _styles = [.. concreteMemento.Styles];
        }
        else
        {
            throw new ArgumentException("Неверный тип снимка состояния");
        }
    }

    public void PrintState()
    {
        Console.WriteLine($"Text: '{_text}', Font: {_currentFont}, Cursor: {_cursorPos}");
    }

    private class EditorMemento(string text, Vector2 cursorPos, string currentFont, List<string> styles) : IMemento
    {
        public string Text { get; } = text;
        public Vector2 CursorPos { get; } = cursorPos;
        public string CurrentFont { get; } = currentFont;
        public List<string> Styles { get; } = [.. styles];
    }

    public void Save()
    {
        var snapshot = CreateSnapshot();
        History.Push(snapshot);
        Console.WriteLine("[Editor] State saved to history.");
    }
    public void Undo()
    {
        var previousMemento = History.Pop();

        if (previousMemento != null)
        {
            Restore(previousMemento);
            Console.WriteLine("[Editor] Cancel of changes.");
        }
        else
        {
            Console.WriteLine("[Editor] Nothing to cancel, history is empty.");
        }
    }

}
