namespace REFRESH.GoF.Behavioral._06_Observer;

public class Application
{
    public void Config()
    {
        var editor = new Editor();

        var logger = new LoggingListener("/path/to/log.txt", "Someone has opened the file: %s");
        editor.Events.Subscribe(EventType.Open, logger);

        var emailAlerts = new EmailAlertsListener("admin@example.com", "Someone has changed the file: %s");
        editor.Events.Subscribe(EventType.Save, emailAlerts);

        editor.OpenFile("test.txt");
        editor.SaveFile();
    }
}