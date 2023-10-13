using System;

namespace DesignPatterns.Behavioral.Observer;

public interface IDeLorean
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}

public class DeLorean : IDeLorean
{
    private List<IObserver> _observers;
    public string Location { get; private set; }

    public DeLorean()
    {
        _observers = new List<IObserver>();
        Location = "1985";
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(Location);   
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void TimeTravel(string year)
    {
        Location = year;
        Console.WriteLine($"DeLorean traveled to {year}!");
        NotifyObservers();
    }
}