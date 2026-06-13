namespace REFRESH.GoF.Behavioral._07_State;

public class AudioPlayer : IState
{
    private State _state;
    public AudioPlayer() => _state = new ReadyState(this);
    public void ChangeState(State state) => _state = state;
    public void ClickLock() => _state.ClickLock();

    public void ClickNext() => _state.ClickNext();

    public void ClickPlay() => _state.ClickPlay();

    public void ClickPrevious() => _state.ClickPrevious();
}
