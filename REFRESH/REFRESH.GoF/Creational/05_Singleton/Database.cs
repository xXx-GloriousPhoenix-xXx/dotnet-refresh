namespace REFRESH.GoF.Creational._05_Singleton;
public class Database
{
    private static Database? _instance;
    private readonly string _connectionString;
    private Database()
    {
        _connectionString = "Server=myServerAddress;Database=myDb;";
        Console.WriteLine("Connection with database established");
    }
    public static Database GetDatabase()
    {
        _instance ??= new();
        return _instance;
    }
    public void ExecuteQuery(string query)
    {
        Console.WriteLine($"Executing {query}, Connection: {_connectionString}");
    }
}
