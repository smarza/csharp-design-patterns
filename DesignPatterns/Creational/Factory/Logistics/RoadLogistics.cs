namespace DesignPatterns.Creational.Factory;

public class RoadLogistics : Logistics
{
    protected override ITransport CreateTransport()
    {
        return new Truck();
    }
}
