namespace REFRESH.GoF.Behavioral._04_Mediator;

public interface IMediator
{
    public void Notify(Component sender, string e);
} 
