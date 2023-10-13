namespace DesignPatterns.Creational.Factory;

public abstract class Logistics
{
    protected abstract ITransport CreateTransport();

    public string PlanDelivery()
    {
        var transport = CreateTransport();
        return transport.Deliver();
    }
}
