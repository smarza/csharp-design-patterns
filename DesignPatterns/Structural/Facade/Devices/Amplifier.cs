namespace DesignPatterns.Structural.Facade;

public interface IAmplifier
{
    public void Initialize();
    public void SetSurround(string mode);
}

public class Amplifier : IAmplifier
{
    public void Initialize()
    {
        Console.WriteLine("[ok] Amplifier Initialized.");
    }

    public void SetSurround(string mode)
    {
        Console.WriteLine($"     Amplifier in {mode}.");
    }
}
