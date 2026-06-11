namespace REFRESH.GoF.Structural._05_Facade;

public class Amplifier
{
    private uint _volume = 50;
    private string _source = "Default";
    public void SetSource(string source) => _source = source;
    public void VolumeUp(uint addVolume = 10) => _volume = Math.Min(_volume + addVolume, 100);
    public void VolumeDown(uint subVolume = 10) => _volume = Math.Max(_volume - subVolume, 0);
}
