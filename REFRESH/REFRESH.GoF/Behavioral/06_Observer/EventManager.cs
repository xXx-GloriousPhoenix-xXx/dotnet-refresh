namespace REFRESH.GoF.Behavioral._06_Observer;

public class EventManager
{
    private readonly Dictionary<EventType, List<IEventListener>> _listeners = [];

    public void Subscribe(EventType eventType, IEventListener listener)
    {
        if (!_listeners.ContainsKey(eventType))
            _listeners[eventType] = [];

        _listeners[eventType].Add(listener);
    }

    public void Unsubscribe(EventType eventType, IEventListener listener)
    {
        if (_listeners.TryGetValue(eventType, out List<IEventListener>? value))
            value.Remove(listener);
    }

    public void Notify(EventType eventType, string filename)
    {
        if (_listeners.TryGetValue(eventType, out var eventListeners))
        {
            foreach (var listener in eventListeners)
            {
                listener.Update(filename);
            }
        }
    }
}
