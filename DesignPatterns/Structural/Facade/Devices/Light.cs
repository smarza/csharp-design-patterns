namespace DesignPatterns.Structural.Facade;

public interface ILight
{
    public void Initialize();
    public void SetBrightness(int intensity);
}

public class Light : ILight
{
    public void Initialize()
    {
        Console.WriteLine("[ok] Light Initialized.");
    }

    public void SetBrightness(int intensity)
    {
        Console.WriteLine($"     Light Brightness set to {intensity}.");
    }
}
