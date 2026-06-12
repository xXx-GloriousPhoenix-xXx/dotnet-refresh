namespace REFRESH.GoF.Behavioral._04_Mediator;

public class Checkbox(IMediator _mediator) : Component(_mediator)
{
    public bool IsChecked { get; private set; }
    public void Check()
    {
        IsChecked = !IsChecked;
        _mediator.Notify(this, IsChecked ? "Checked" : "Unchecked");
    }
}
