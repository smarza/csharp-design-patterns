namespace DesignPatterns.Behavioral.Observer;

public class MonitoringDevice : IObserver
{
    private string _name;

    public MonitoringDevice(string name)
    {
        _name = name;
    }

    public void Update(string location)
    {
        Console.WriteLine($"{_name} detected DeLorean at {location}!");
    }
}