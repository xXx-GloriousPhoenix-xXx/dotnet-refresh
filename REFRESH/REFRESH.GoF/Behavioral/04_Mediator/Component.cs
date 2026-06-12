namespace REFRESH.GoF.Behavioral._04_Mediator;
public class Component(IMediator _mediator)
{
    protected IMediator _mediator = _mediator;
    public void Click()
    {
        _mediator.Notify(this, "Click");
    }
    public void Keypress()
    {
        _mediator.Notify(this, "Keypress");
    }
}
