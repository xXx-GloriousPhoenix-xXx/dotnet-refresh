namespace REFRESH.GoF.Behavioral._07_State;

public abstract class State(AudioPlayer player) : IState
{
    protected readonly AudioPlayer _player = player;
    public abstract void ClickLock();
    public abstract void ClickPlay();
    public abstract void ClickNext();
    public abstract void ClickPrevious();
}
