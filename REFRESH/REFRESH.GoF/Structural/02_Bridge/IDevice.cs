namespace REFRESH.GoF.Structural._02_Bridge;

public interface IDevice
{
    bool IsEnabled();
    void Enable();
    void Disable();
    uint GetVolume();
    void SetVoume(uint volume);
    uint GetChannel();
    void SetChannel(uint channel);
}
