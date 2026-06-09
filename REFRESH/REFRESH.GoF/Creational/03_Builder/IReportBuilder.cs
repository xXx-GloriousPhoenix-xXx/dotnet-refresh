namespace REFRESH.GoF.Creational._03_Builder;
public interface IReportBuilder
{
    IReportBuilder SetTitle(string title);
    IReportBuilder AddText(string text);
    IReportBuilder AddTable(string[] headers, string[][] rows);
}
