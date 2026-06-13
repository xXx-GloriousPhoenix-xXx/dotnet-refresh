namespace REFRESH.GoF.Structural._01_Adapter.DataAdapter;

public class XMLtoJSONAdapter(JSONDataAnalyzer analyzer)
{
    private readonly JSONDataAnalyzer _analyzer = analyzer;
    public void AnalyzeJSONData(XMLData xmlData)
    {
        _analyzer.AnalyzeJSONData(new JSONData(xmlData.XmlData));
    }
}