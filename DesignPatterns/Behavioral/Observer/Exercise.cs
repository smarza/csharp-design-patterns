namespace DesignPatterns.Behavioral.Observer;

public class Exercise : BaseExercise
{

    public Exercise() : base()
    {
    }

    public override void Execute()
    {
        var delorean = new DeLorean();
        var device1 = new MonitoringDevice("Device1");
        var device2 = new MonitoringDevice("Device2");

        delorean.RegisterObserver(device1);
        delorean.RegisterObserver(device2);

        delorean.TimeTravel("2015");
        delorean.TimeTravel("1955");
    }

}
