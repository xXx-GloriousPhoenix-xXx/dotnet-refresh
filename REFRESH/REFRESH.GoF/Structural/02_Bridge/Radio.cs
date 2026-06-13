namespace REFRESH.GoF.Structural._02_Bridge;

public class Radio : IDevice
{
    private bool _enabled = false;
    private uint _volume = 50;
    private uint _channel = 1;
    public void Disable()
    {
        _enabled = false;
    }

    public void Enable()
    {
        _enabled = true;
    }

    public uint GetChannel()
    {
        return _channel;
    }

    public uint GetVolume()
    {
        return _volume;
    }

    public bool IsEnabled()
    {
        return _enabled;
    }

    public void SetChannel(uint channel)
    {
        _channel = channel;
    }

    public void SetVoume(uint volume)
    {
        _volume = volume;
    }
}
