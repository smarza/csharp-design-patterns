namespace DesignPatterns.Behavioral.Proxy;

public class RealCat : ICat
{
    private string _name;

    public RealCat(string name)
    {
        _name = name;
        LoadData();
    }
    private void LoadData()
    {
        Console.WriteLine($"Loading data for {_name}...");
    }

    public void ShowData()
    {
        Console.WriteLine($"Showing data of {_name}.");
    }
}
