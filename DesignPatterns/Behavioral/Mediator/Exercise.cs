namespace DesignPatterns.Behavioral.Mediator;

public class Exercise : BaseExercise
{

    public Exercise() : base()
    {
    }

    public override void Execute()
    {
        var mediator = new SpaceXMediator();

        var flightTrackingSystem = new FlightTrackingSystem(mediator);
        var rocketMaintenanceSystem = new RocketMaintenanceSystem(mediator);
        var satelliteSystem = new SatelliteSystem(mediator);

        var rocket = new Rocket(mediator);

        rocket.Launch();
        rocket.ProblemDetected();
    }

}
