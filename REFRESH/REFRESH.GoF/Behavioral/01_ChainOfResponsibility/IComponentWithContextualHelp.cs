namespace REFRESH.GoF.Behavioral._01_ChainOfResponsibility;
public interface IComponentWithContextualHelp
{
    void ShowHelp();
    IComponentWithContextualHelp SetNext(IComponentWithContextualHelp nextHandler);
}
