namespace REFRESH.GoF.Behavioral._06_Observer;

public class Editor
{
    public EventManager Events { get; } = new();
    private string _filename = string.Empty;

    public void OpenFile(string filename)
    {
        _filename = filename;
        Console.WriteLine($"[Editor] Openning file: {filename}");
        Events.Notify(EventType.Open, filename);
    }

    public void SaveFile()
    {
        Console.WriteLine($"[Editor] Saving file: {_filename}");
        Events.Notify(EventType.Save, _filename);
    }
}
