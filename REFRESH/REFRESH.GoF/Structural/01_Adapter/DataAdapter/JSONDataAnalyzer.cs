namespace REFRESH.GoF.Structural._01_Adapter.DataAdapter;

public class JSONDataAnalyzer : IJSONDataAnalyzer
{
    public void AnalyzeJSONData(JSONData jsonData)
    {
        Console.WriteLine("Analyzing...");
    }
}
