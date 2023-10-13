namespace DesignPatterns.Behavioral.Mediator;

public class FlightTrackingSystem
{
    private ISpaceXMediator _mediator;

    public FlightTrackingSystem(ISpaceXMediator mediator)
    {
        _mediator = mediator;
        mediator.FlightTrackingSystem = this;
    }

    internal void TrackRocket()
    {
        Console.WriteLine($"{GetType().Name}: Tracking the rocket.");
    }
}
