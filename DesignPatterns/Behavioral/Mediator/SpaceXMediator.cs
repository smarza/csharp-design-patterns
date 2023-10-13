namespace DesignPatterns.Behavioral.Mediator;

public interface ISpaceXMediator
{
    public SatelliteSystem SatelliteSystem { get; set; }
    public FlightTrackingSystem FlightTrackingSystem { get; set; }
    public RocketMaintenanceSystem RocketMaintenanceSystem { get; set; }
    void Notify(object sender, string eventInfo);
}

public class SpaceXMediator : ISpaceXMediator
{
    public SatelliteSystem SatelliteSystem { get; set; }
    public FlightTrackingSystem FlightTrackingSystem { get; set; }
    public RocketMaintenanceSystem RocketMaintenanceSystem { get; set; }
    public void Notify(object sender, string eventInfo)
    {

        if (sender is Rocket)
        {
            if (eventInfo == "Launch")
            {
                FlightTrackingSystem.TrackRocket();
                SatelliteSystem.AdjustForRocketCommunication();
            }
            else if (eventInfo == "Problem")
            {
                RocketMaintenanceSystem.NotifyForInspection();
            }
        }

    }
}

