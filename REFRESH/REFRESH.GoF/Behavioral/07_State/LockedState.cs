namespace REFRESH.GoF.Behavioral._07_State;

public class LockedState(AudioPlayer player) : State(player)
{
    public override void ClickLock() => _player.ChangeState(new ReadyState(_player));
    public override void ClickPlay() { }
    public override void ClickNext() { }
    public override void ClickPrevious() { }
}
