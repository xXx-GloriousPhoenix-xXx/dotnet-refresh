namespace REFRESH.GoF.Structural._01_Adapter.Logger;
public interface IAppLogger
{
    void LogInfo(string message);
    void LogError(string message);
}
