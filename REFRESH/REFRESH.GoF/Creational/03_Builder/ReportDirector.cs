namespace REFRESH.GoF.Creational._03_Builder;

public class ReportDirector
{
    public void BuildMonthlyReport(IReportBuilder builder)
    {
        builder
            .SetTitle("Monthly Report")
            .AddText("Financial Stats")
            .AddTable(headers: ["Day", "Income"],
                      rows: [["1", "100$"],
                             ["2", "150$"]]);
    }
}