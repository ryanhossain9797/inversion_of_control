namespace DBLibrary;

public class DBLib : IDBLib
{
    private readonly ILogger _logger;
    private readonly IDatabase _database;

    public DBLib(
        ILogger logger,
        IDatabase database
    )
    {
        _logger = logger;
        _database = database;
        Console.WriteLine("Initialized DBLib");
    }

    public int[] GetDataFromDb()
    {

        _logger.Log("fetching data");
        var data = _database.GetData();
        _logger.Log("returning data");
        return data;
    }
}
