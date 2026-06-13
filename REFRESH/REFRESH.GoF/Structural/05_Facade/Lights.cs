namespace REFRESH.GoF.Structural._05_Facade;

public class Lights
{
    private uint _brightness = 80;
    public void SetBrightness(uint brightness) => _brightness = brightness;
    public void Darken() => SetBrightness(25);
    public void Lighten() => SetBrightness(80);
}
