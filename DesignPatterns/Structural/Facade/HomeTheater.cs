namespace DesignPatterns.Structural.Facade;

public class HomeTheaterFacade
{
    private readonly IProjector _projector;
    private readonly ILight _light;
    private readonly IAmplifier _amplifier;

    public HomeTheaterFacade(IProjector projector, ILight light, IAmplifier amplifier)
    {
        _projector = projector;
        _light = light;
        _amplifier = amplifier;
    }

    public void PlayMovie(string movieName)
    {
        Console.WriteLine($"Preparing to watch the movie {movieName}.");

        _projector.Initialize();
        _projector.SetMovieMode();

        _light.Initialize();
        _light.SetBrightness(10);

        _amplifier.Initialize();
        _amplifier.SetSurround("Dolby Atmos");

        Console.WriteLine("All set.");
    }
}
