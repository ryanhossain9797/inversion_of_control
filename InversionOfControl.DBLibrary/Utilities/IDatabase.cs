namespace DBLibrary;

public interface IDatabase
{
    int[] GetData();

    void AddData(int[] data);
}