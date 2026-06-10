namespace REFRESH.GoF.Structural._02_Bridge;
public class Remote(IDevice device)
{
    protected readonly IDevice _device = device;
    public void TogglePower()
    {
        if (_device.IsEnabled())
        {
            _device.Disable();
        }
        else
        {
            _device.Enable();
        }
    }
    public void VolumeDown()
    {
        var volume = _device.GetVolume();
        if (volume > 0)
        {
            _device.SetVoume(volume - 1);
        }
        else
        {
            _device.SetVoume(0);
        }
    }
    public void VolumeUp()
    {
        var volume = _device.GetVolume();
        if (volume < 100)
        {
            _device.SetVoume(volume + 1);
        }
        else
        {
            _device.SetVoume(100);
        }
    }
    public void ChannelDown()
    {
        _device.SetChannel(_device.GetChannel() - 1);
    }
    public void ChannelUp()
    {
        _device.SetChannel(_device.GetChannel() + 1);
    }
}
