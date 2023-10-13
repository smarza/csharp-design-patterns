namespace DesignPatterns.Creational.Singleton;

public interface ICounter
{
    public void Add();
    public int Reveal();
}

public sealed class Counter : ICounter
{
    private int _count;

    private static readonly Lazy<ICounter> _instance = new Lazy<ICounter>(() => new Counter());

    public static ICounter Instance
    {
        get { return _instance.Value; }
    }

    private Counter()
    {
        _count = 0;
    }

    public void Add()
    {
        _count++;
    }

    public int Reveal()
    {
        return _count;
    }
}
