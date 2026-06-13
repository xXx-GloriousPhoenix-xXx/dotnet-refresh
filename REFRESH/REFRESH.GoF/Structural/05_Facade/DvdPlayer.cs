namespace REFRESH.GoF.Structural._05_Facade;

public class DvdPlayer
{
    private string _movie = "Lord of the Rings";
    private bool _playing = false;
    public void Play() => _playing = true;
    public void Pause() => _playing = false;
    public void SetMovie(string movie)
    {
        Pause();
        _movie = movie;
    }
}
