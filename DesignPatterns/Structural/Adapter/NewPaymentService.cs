namespace DesignPatterns.Structural.Adapter;

public interface INewPaymentService
{
    void ExecuteTransaction(string creditCard, double value);
}

public class NewPaymentService : INewPaymentService
{
    public void ExecuteTransaction(string creditCard, double value)
    {
        Console.WriteLine($"Executing transaction of {value} using new payment service for card: {creditCard}");
    }
}
