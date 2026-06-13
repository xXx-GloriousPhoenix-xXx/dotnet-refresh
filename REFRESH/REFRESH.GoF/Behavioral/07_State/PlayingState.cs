namespace REFRESH.GoF.Behavioral._07_State;
public class PlayingState(AudioPlayer player) : State(player)
{
    public override void ClickLock() => _player.ChangeState(new LockedState(_player));
    public override void ClickPlay() => _player.ChangeState(new ReadyState(_player));
    public override void ClickNext() { }
    public override void ClickPrevious() { }
}