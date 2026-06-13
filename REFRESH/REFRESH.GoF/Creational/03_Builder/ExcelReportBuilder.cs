namespace REFRESH.GoF.Creational._03_Builder;

public class ExcelReportBuilder : LegacyExcelApplication, IReportBuilder
{
    private readonly List<string> _report = [];

    public ExcelReportBuilder()
    {
        InitComObject();
    }

    public IReportBuilder SetTitle(string title)
    {
        _report.Add($"[TITLE]: {title}");
        return this;
    }

    public IReportBuilder AddText(string text)
    {
        _report.Add($"[TEXT]: {text}");
        return this;
    }

    public IReportBuilder AddTable(string[] headers, string[][] rows)
    {
        _report.Add(string.Join("\t", headers));
        foreach (var row in rows)
        {
            _report.Add(string.Join("\t", row));
        }
        return this;
    }

    public ExcelFile Build()
    {
        var result = new ExcelFile([.. _report]);
        _report.Clear();
        return result;
    }

    public void SaveFileToDisk(string path)
    {
        SaveWorkbook(path);
    }
}
