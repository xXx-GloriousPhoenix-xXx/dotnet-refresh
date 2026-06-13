using System.Text;

namespace REFRESH.GoF.Creational._03_Builder;

public class HtmlReportBuilder : WebComponentBase, IReportBuilder
{
    private readonly StringBuilder _report = new();
    public HtmlReportBuilder()
    {
        _report.AppendLine(GetCompanyCss());
    }
    public IReportBuilder SetTitle(string title)
    {
        _report.AppendLine($"<h1>{title}</h1>");
        return this;
    }
    public IReportBuilder AddText(string text)
    {
        _report.AppendLine($"<p>{text}</p>");
        return this;
    }

    public IReportBuilder AddTable(string[] headers, string[][] rows)
    {
        _report.AppendLine("<table>");
        _report.AppendLine("  <tr><th>" + string.Join("</th><th>", headers) + "</th></tr>");

        foreach (var row in rows)
        {
            _report.AppendLine("  <tr><td>" + string.Join("</td><td>", row) + "</td></tr>");
        }
        _report.AppendLine("</table>");

        return this;
    }

    public string Build()
    {
        var result = _report.ToString();
        _report.Clear();
        return result;
    }
}
