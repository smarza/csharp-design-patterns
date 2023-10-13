namespace DesignPatterns.Structural.Adapter;

public interface IOldPaymentSystem
{
    void ProcessPayment(string cardNumber, double amount);
}

public class OldPaymentSystem : IOldPaymentSystem
{
    public void ProcessPayment(string cardNumber, double amount)
    {
        Console.WriteLine($"Processing payment of {amount} using old payment system for card: {cardNumber}");
    }
}
