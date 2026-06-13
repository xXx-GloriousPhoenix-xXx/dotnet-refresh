namespace REFRESH.GoF.Creational._03_Builder;

public class LegacyExcelApplication
{
    protected void InitComObject() => Console.WriteLine("[COM] Подключение к Excel.exe...");
    protected void SaveWorkbook(string path) => Console.WriteLine($"[COM] Сохранение файла {path}");
}
