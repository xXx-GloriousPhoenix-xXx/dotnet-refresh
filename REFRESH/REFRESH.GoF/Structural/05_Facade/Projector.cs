namespace REFRESH.GoF.Structural._05_Facade;
public class Projector
{
    private bool _switchedOn = false;
    private string _mode = "Default";
    public void ToggleSwitch() => _switchedOn = !_switchedOn;
    public void SetMode(string mode) => _mode = mode;
    public void SetWidescreenMode() => SetMode("Widescreen");
    public void SetDefaultMode() => SetMode("Default");
}
