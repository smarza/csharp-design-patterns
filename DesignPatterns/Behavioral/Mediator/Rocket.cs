namespace DesignPatterns.Behavioral.Mediator;

public class Rocket
{
    private ISpaceXMediator _mediator;

    public Rocket(ISpaceXMediator mediator)
    {
        _mediator = mediator;
    }

    public void Launch()
    {
        Console.WriteLine($"{GetType().Name}: Launching.");
        _mediator.Notify(this, "Launch");
    }

    public void ProblemDetected()
    {
        Console.WriteLine($"{GetType().Name}: Problem Detected.");
        _mediator.Notify(this, "Problem");
    }

}
