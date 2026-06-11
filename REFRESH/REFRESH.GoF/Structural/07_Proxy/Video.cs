namespace REFRESH.GoF.Structural._07_Proxy;

public class Video(string title, string description)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Title { get; private set; } = title;
    public string Description { get; private set; } = description;
}
