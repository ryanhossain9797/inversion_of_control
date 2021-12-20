namespace DBLibrary;

public class Database : IDatabase
{
    public Database()
    {
        Console.WriteLine("Initialized Database");
    }

    public int[] GetData()
    {
        return new int[] { 1, 2, 3 };
    }

    public void AddData(int[] data)
    {
        Console.WriteLine(data.ToString());
    }
}