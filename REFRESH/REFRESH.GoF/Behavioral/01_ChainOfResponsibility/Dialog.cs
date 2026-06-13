namespace REFRESH.GoF.Behavioral._01_ChainOfResponsibility;

public class Dialog : Container
{
    private readonly string? _wikiPageUrl;
    public Dialog(string? helpText, string? wikiPageUrl = null)
    {
        HelpText = helpText;
        _wikiPageUrl = wikiPageUrl;
    }
    public override void ShowHelp()
    {
        if (!string.IsNullOrEmpty(_wikiPageUrl))
        {
            Console.WriteLine($"[Wiki Page Help] Openning page - {_wikiPageUrl}");
        }
        else
        {
            base.ShowHelp();
        }
    }
}