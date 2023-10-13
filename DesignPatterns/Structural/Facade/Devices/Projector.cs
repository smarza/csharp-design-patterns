namespace DesignPatterns.Structural.Facade;

public interface IProjector
{
    public void Initialize();
    public void SetMovieMode();
}

public class Projector : IProjector
{
    public void Initialize()
    {
        Console.WriteLine("[ok] Projector Initialized.");
    }

    public void SetMovieMode()
    {
        Console.WriteLine("     Projector in Movie Mode.");
    }
}
