namespace REFRESH.GoF.Structural._02_Bridge;

public class AdvancedRemote(IDevice device) : Remote(device)
{
    public void Mute()
    {
        _device.SetVoume(0);
    }
}