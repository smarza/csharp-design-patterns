namespace DesignPatterns.Behavioral.Mediator;

public class RocketMaintenanceSystem
{
    private ISpaceXMediator _mediator;

    public RocketMaintenanceSystem(ISpaceXMediator mediator)
    {
        _mediator = mediator;
        mediator.RocketMaintenanceSystem = this;
    }

    internal void NotifyForInspection()
    {
        Console.WriteLine($"{GetType().Name}: Rocket needs maintenance inspection.");
    }
}
