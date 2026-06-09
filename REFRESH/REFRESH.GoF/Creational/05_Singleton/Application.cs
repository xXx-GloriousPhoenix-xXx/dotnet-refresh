namespace REFRESH.GoF.Creational._05_Singleton;

public class Application
{
    public void Main()
    {
        var db1 = Database.GetDatabase();
        db1.ExecuteQuery("SELECT * FROM Users");

        var db2 = Database.GetDatabase();
        db2.ExecuteQuery("SELECT * FROM Orders");

        Console.WriteLine(db1 == db2);
    }
}