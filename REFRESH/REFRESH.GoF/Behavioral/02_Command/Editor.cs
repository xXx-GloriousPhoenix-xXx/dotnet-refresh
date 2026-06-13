namespace REFRESH.GoF.Behavioral._02_Command;
public class Editor(string? text = null) : ICloneable
{
    private string? _text = text;
    public string GetSelection() => _text ?? string.Empty;
    public void ReplaceSelection(string text) => _text = text;
    public void RemoveSelection() => _text = null;
    public object Clone()
    {
        return new Editor(_text);
    }
}
