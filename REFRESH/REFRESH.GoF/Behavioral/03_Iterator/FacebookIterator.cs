namespace REFRESH.GoF.Behavioral._03_Iterator;

public class FacebookIterator(List<Profile> profiles) : IProfileIterator
{
    private readonly List<Profile> _profiles = profiles;
    private int _currentPosition = 0;
    public Profile GetNext()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException("No more elements in collection");
        }

        return _profiles[_currentPosition++];
    }
    public bool HasNext()
    {
        return _currentPosition < _profiles.Count;
    }
}
