namespace Primary;

using DBLibrary;

public class Application : IApplication
{

    private readonly IDBLib _dbLib;
    public Application(IDBLib dbLib)
    {
        _dbLib = dbLib;
        Console.WriteLine("Initialized Application");
    }

    public void Run()
    {
        var data = _dbLib.GetDataFromDb();
        Console.WriteLine(string.Join(", ", data));
    }
}