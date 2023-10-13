namespace DesignPatterns.Behavioral.Mediator;

public class SatelliteSystem
{
    private ISpaceXMediator _mediator;

    public SatelliteSystem(ISpaceXMediator mediator)
    {
        _mediator = mediator;
        mediator.SatelliteSystem = this;
    }

    internal void AdjustForRocketCommunication()
    {
        Console.WriteLine($"{GetType().Name}: Adjusting satellites for rocket communication.");
    }
}
