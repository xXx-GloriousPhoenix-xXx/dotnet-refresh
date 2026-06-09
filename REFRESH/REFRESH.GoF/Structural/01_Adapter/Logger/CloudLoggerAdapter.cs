namespace REFRESH.GoF.Structural._01_Adapter.Logger;

public class CloudLoggerAdapter(CloudLogger logger) : IAppLogger
{
    private readonly CloudLogger _logger = logger;
    public void LogError(string message)
    {
        _logger.SendMessage(CloudLogLevel.CriticalError, message);
    }

    public void LogInfo(string message)
    {
        _logger.SendMessage(CloudLogLevel.Information, message);
    }
}
