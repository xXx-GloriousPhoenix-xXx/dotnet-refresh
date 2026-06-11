namespace REFRESH.GoF.Structural._05_Facade;

public class HomeTheaterFacade(Projector projector, Lights lights, Amplifier amplifier, DvdPlayer dvdPlayer)
{
    private readonly Projector _projector = projector;
    private readonly Lights _lights = lights;
    private readonly Amplifier _amplifier = amplifier;
    private readonly DvdPlayer _dvdPlayer = dvdPlayer;

    public void WatchMovie(string movie)
    {
        _projector.ToggleSwitch();
        _projector.SetWidescreenMode();

        _lights.Darken();

        _amplifier.SetSource("TV amplifier");
        _amplifier.VolumeUp();

        _dvdPlayer.SetMovie(movie);
        _dvdPlayer.Play();
    }
    public void EndMovie()
    {
        _dvdPlayer.Pause();

        _amplifier.VolumeDown();

        _lights.Lighten();

        _projector.ToggleSwitch();
    }
}